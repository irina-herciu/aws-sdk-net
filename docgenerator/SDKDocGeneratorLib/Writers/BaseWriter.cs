﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection;

namespace SDKDocGenerator.Writers
{
    public abstract class BaseWriter
    {
        protected FrameworkVersion _version;        

        public static readonly List<TableColumnHeader> FieldTableColumnHeaders = new List<TableColumnHeader>
        {
            new TableColumnHeader { CssClass = "iconColumn" },
            new TableColumnHeader {Title = "Name", CssClass = "nameColumn"},
            new TableColumnHeader {Title = "Type", CssClass = "typeColumn"},
            new TableColumnHeader {Title = "Description", CssClass = "descriptionColumn"}
        };

        public static readonly List<TableColumnHeader> PropertiesTableColumnHeaders = new List<TableColumnHeader>
        {
            new TableColumnHeader { CssClass = "iconColumn" },
            new TableColumnHeader {Title = "Name", CssClass = "nameColumn"},
            new TableColumnHeader {Title = "Type", CssClass = "typeColumn"},
            new TableColumnHeader {Title = "Description", CssClass = "descriptionColumn"}
        };

        public static readonly List<TableColumnHeader> IconisedNameDescriptionTableColumnHeaders = new List<TableColumnHeader>
        {
            new TableColumnHeader {CssClass = "iconColumn"},
            new TableColumnHeader {Title = "Name", CssClass = "nameColumn"},
            new TableColumnHeader {Title = "Description", CssClass = "descriptionColumn"}
        };

        public static readonly List<TableColumnHeader> NameDescriptionTableColumnHeaders = new List<TableColumnHeader>
        {
            new TableColumnHeader {Title = "Name", CssClass = "nameColumn"},
            new TableColumnHeader {Title = "Description", CssClass = "descriptionColumn"}
        };

        private const string FeedbackSection =
            "<!-- BEGIN-FEEDBACK-SECTION --><span class=\"feedback\">{0}</span><!-- END-FEEDBACK-SECTION -->";

        public static string BJSDisclaimerTemplate
                    = "AWS services or capabilities described in AWS Documentation may vary by region/location. "
                    + "Click <a href=\"https://{0}/en_us/aws/latest/userguide/services.html\">Getting Started with Amazon AWS</a> to see specific differences applicable to the China (Beijing) Region.";
        
        public GenerationManifest Artifacts { get; private set; }
        public AbstractTypeProvider TypeProvider { get; private set; }

        protected BaseWriter(GenerationManifest artifacts, AbstractTypeProvider typeProvider, FrameworkVersion version)
        {
            Artifacts = artifacts;
            TypeProvider = typeProvider;
            _version = version;
        }

        protected BaseWriter(GenerationManifest artifacts, FrameworkVersion version)
            : this(artifacts, artifacts.ManifestAssemblyContext.SdkAssembly, version)
        {
        }

        public string BJSRegionDisclaimer
        {
            get
            {
                return string.Format(BJSDisclaimerTemplate, Artifacts.Options.BJSDocsDomain);
            }
        }

        protected abstract string GetTitle();
        protected abstract string GetMemberName();
        protected abstract string GetMemberType();
        protected abstract string GenerateFilename();
        protected abstract string GenerateFilepath();
        protected abstract XElement GetSummaryDocumentation();

        protected virtual void AddSummaryNotes(TextWriter writer)
        {
        }

        protected abstract void WriteContent(TextWriter writer);

        // the computed relative path(s) to the root of the doc set 
        // (ie to the folder containing ./items)
        protected string RootRelativePath { get; private set; }

        public void Write()
        {
            var filename = Path.Combine(Artifacts.OutputFolder, GenerateFilepath(), GenerateFilename());
            try
            {
                RootRelativePath = ComputeRelativePathToRoot(filename);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path is too long for file : {0}", filename);
                throw;
            }

            var directory = new FileInfo(filename).Directory.FullName;

            if (!Directory.Exists(directory))
            {
                Console.WriteLine("\t\tcreating directory: {0}", directory);
                Directory.CreateDirectory(directory);
            }

            using (var writer = new StringWriter())
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
               
                writer.WriteLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"/>");

                writer.WriteLine("<meta name=\"guide-name\" content=\"API Reference\"/>");
                writer.WriteLine("<meta name=\"service-name\" content=\"AWS SDK for .NET Version 4\"/>");

                writer.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"{0}/resources/style.css\"/>", RootRelativePath);
                writer.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"{0}/resources/syntaxhighlighter/shCore.css\">", RootRelativePath);
                writer.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"{0}/resources/syntaxhighlighter/shThemeDefault.css\">", RootRelativePath);
                writer.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"{0}/resources/sdkstyle.css\"/>", RootRelativePath);

                // every page needs a title, meta description and canonical url to satisfy indexing. The summary/synopsis
                // text for an element has proven unreliable as a useful source for info the search results so stay with
                // the page title for now
                writer.WriteLine("<meta name=\"description\" content=\"{0}\">", GetTitle());
                writer.WriteLine("<title>{0} | AWS SDK for .NET Version 4</title>", GetTitle());                
                writer.WriteLine("<script type=\"text/javascript\" src=\"/assets/js/awsdocs-boot.js\"></script>");
                writer.WriteLine("<link rel=\"canonical\" href=\"https://docs.aws.amazon.com/sdkfornet/v4/apidocs/index.html?page={0}&tocid={1}\"/>",
                                FilenameGenerator.Escape(this.GenerateFilename()),
                                FilenameGenerator.Escape(this.GetTOCID()));

                writer.WriteLine("</head>");                     

                writer.WriteLine("<body>");

                    // every page needs two hidden divs giving the search indexer the product title and guide name
                    writer.WriteLine("<div id=\"product_name\">AWS SDK Version 4 for .NET</div>");
                    writer.WriteLine("<div id=\"guide_name\">API Reference</div>");

                    WriteRegionDisclaimer(writer);
                    
                    this.WriteHeader(writer);
                    this.WriteToolbar(writer);

                    writer.WriteLine("<div id=\"pageContent\">");
                        this.WriteContent(writer);
                    writer.WriteLine("</div>");

                    this.WriteFooter(writer);

                writer.WriteLine("</body>");
                writer.WriteLine("</html>");

                // normalize all line endings so any docs committed into Git present a consistent
                // set of line terminators for core.autocrlf to work with
                var content = new StringBuilder(writer.ToString());
                content.Replace("\r\n", "\n").Replace("\n", "\r\n");

                // The XML documentation will use the "<c>" tag, but the corresponding HTML tag is "<code>".
                // There's also a "<code>" tag in XML docs, but it has a different meaning (multiple lines of code); this can cause formatting issues such as
                // https://github.com/aws/aws-sdk-net/issues/1934 and https://github.com/aws/aws-sdk-net/issues/1954
                content
                    .Replace("<c>", "<code>")
                    .Replace("</c>", "</code>");

                using (var fileWriter = new StreamWriter(filename))
                {
                    fileWriter.Write(content);
                }
            }
        }

        protected virtual void WriteRegionDisclaimer(TextWriter writer)
        {
			// comment disclaimer is used by DCA pipeline only at present
            writer.WriteLine("<!--REGION_DISCLAIMER_DO_NOT_REMOVE-->");

            // the BJS disclaimer uses its own div with js/css control of
            // visibility instead of its own pipeline (currently) and that
            // div needs to be suppressed from the dca-deployed docs
            writer.WriteLine("<!-- BEGIN-SECTION -->");
			writer.WriteLine("<div id=\"regionDisclaimer\">");
            writer.WriteLine("<p>{0}</p>", BJSRegionDisclaimer);
            writer.WriteLine("</div>");
            writer.WriteLine("<!-- END-SECTION -->");
        }

        protected virtual void WriteHeader(TextWriter writer)
        {
            writer.WriteLine("<div id=\"pageHeader\">");
                writer.WriteLine("<div id=\"titles\">");
                    writer.WriteLine("<h1>{0}</h1>", this.GetMemberName());
                    if (this.GetMemberType() != null)
                        writer.WriteLine("<h2 class=\"subtitle\">{0}</h2>", this.GetMemberType());
                writer.WriteLine("</div>");
            writer.WriteLine("</div>");
        }

        protected virtual void WriteToolbar(TextWriter writer)
        {
            writer.WriteLine("<div id=\"pageToolbar\">");

                writer.WriteLine("<!-- BEGIN-SECTION -->");
                writer.WriteLine("<div id=\"search\">");
                    writer.WriteLine("<form action=\"/search/doc-search.html\" target=\"_blank\" onsubmit=\"return AWSHelpObj.searchFormSubmit(this);\" method=\"get\">");
                        writer.WriteLine("<div id=\"sfrm\">");
                            writer.WriteLine("<span id=\"lbl\">");
                                writer.WriteLine("<label for=\"sel\">Search: </label>");
                            writer.WriteLine("</span>");
                            writer.WriteLine("<select aria-label=\"Search From\" name=\"searchPath\" id=\"sel\">");
                                writer.WriteLine("<option value=\"all\">Entire Site</option>");
                                writer.WriteLine("<option value=\"articles\">Articles &amp; Tutorials</option>");
                                writer.WriteLine("<option value=\"documentation\">Documentation</option>");
                                writer.WriteLine("<option value=\"documentation-product\">Documentation - This Product</option>");
                                writer.WriteLine("<option selected=\"\" value=\"documentation-guide\">Documentation - This Guide</option>");
                                writer.WriteLine("<option value=\"releasenotes\">Release Notes</option>");
                                writer.WriteLine("<option value=\"code\">Sample Code &amp; Libraries</option>");
                            writer.WriteLine("</select>");
                            writer.WriteLine("<div id=\"searchInputContainer\">");
                                writer.WriteLine("<input aria-label=\"Search\" type=\"text\" name=\"searchQuery\" id=\"sq\">");
                                writer.WriteLine("<input type=\"image\" alt=\"Go\" src=\"{0}/resources/search-button.png\" id=\"sb\">", RootRelativePath);
                            writer.WriteLine("</div>");
                        writer.WriteLine("</div>");
                        writer.WriteLine("<input id=\"this_doc_product\" type=\"hidden\" value=\"AWS SDK for .NET Version 4\" name=\"this_doc_product\">");
                        writer.WriteLine("<input id=\"this_doc_guide\" type=\"hidden\" value=\"API Reference\" name=\"this_doc_guide\">");
                        writer.WriteLine("<input type=\"hidden\" value=\"en_us\" name=\"doc_locale\">");
                    writer.WriteLine("</form>");
                writer.WriteLine("</div>");
                writer.WriteLine("<!-- END-SECTION -->");

            writer.WriteLine("</div>");
        }

        protected virtual void WriteFooter(TextWriter writer)
        {
            writer.WriteLine("<div id=\"pageFooter\">");
                writer.WriteLine("<span class=\"newline linkto\"><a href=\"javascript:void(0)\" onclick=\"AWSHelpObj.displayLink('{0}/{1}', '{2}')\">Link to this page</a></span>",
                                 this.GenerateFilepath(),
                                 FilenameGenerator.Escape(this.GenerateFilename()), 
                                 FilenameGenerator.Escape(this.GetTOCID()));
                writer.WriteLine("<span class=\"divider\">&nbsp;</span>");
                writer.WriteLine(FeedbackSection, GenerateFeedbackHTML());
                writer.WriteLine("<div id=\"awsdocs-legal-zone-copyright\"></div>");
            writer.WriteLine("</div>");
            WriteScriptFiles(writer);
        }

        protected abstract string GetTOCID();

        private string ComputeRelativePathToRoot(string filePath)
        {
            var docsRootFolder = Path.GetDirectoryName(Artifacts.OutputFolder);  // trim ./items
            var pathFromDocsRoot = Path.GetDirectoryName(filePath).Substring(docsRootFolder.Length + 1);
            var pathComponents = pathFromDocsRoot.Split('\\');
            var rel = new StringBuilder();
            for (var i = 0; i < pathComponents.Length; i++)
            {
                if (i > 0)
                    rel.Append("/");
                rel.Append("..");
            }
            return rel.ToString();
        }

        private string GenerateFeedbackHTML()
        {
            var filename = FilenameGenerator.Escape(Path.GetFileNameWithoutExtension(GenerateFilename()));
            const string baseUrl = "https://docs.aws.amazon.com/forms/aws-doc-feedback";
            var queryString = string.Format("?service_name={0}&amp;file_name={1}",
                                            "NET-Ref-V4",  // service_name
                                            filename   // guide_name
                                            );
            var fullUrl = baseUrl + queryString;

            const string feedbackContentFormat = "<span id=\"feedback\">" +
                                                "<!-- BEGIN-FEEDBACK-SECTION -->" +
                                                 "Did this page help you?&nbsp;&nbsp;" +
                                                 "<a href=\"https://docs.aws.amazon.com/sdkfornet/v4/apidocs/feedbackyes.html?topic_id={0}\" target=\"_blank\">Yes</a>&nbsp;&nbsp;" +
                                                 "<a href=\"https://docs.aws.amazon.com/sdkfornet/v4/apidocs/feedbackno.html?topic_id={0}\" target=\"_blank\">No</a>&nbsp;&nbsp;&nbsp;" +
                                                 "<a href=\"{1}\" target=\"_blank\">Tell us about it...</a>" +
                                                 "</span>" +
                                                 "<!-- END-FEEDBACK-SECTION -->";
            string feedbackContent = string.Format(feedbackContentFormat, filename, fullUrl);
            return feedbackContent;
        }

        protected virtual void WriteScriptFiles(TextWriter writer)
        {
            var isCore = Artifacts.ServiceName.Equals("Core", StringComparison.OrdinalIgnoreCase);

            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/jquery.min.js\"></script>", RootRelativePath);
            writer.WriteLine("<script type=\"text/javascript\">jQuery.noConflict();</script>");
            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/parseuri.js\"></script>", RootRelativePath);
            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/pagescript.js\"></script>", RootRelativePath);
            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/parentloader.js\"></script>", RootRelativePath);
            writer.WriteLine("<!-- BEGIN-SECTION -->");
            writer.WriteLine("<script type=\"text/javascript\">");
            writer.WriteLine("jQuery(function ($) {");
            writer.WriteLine("var host = parseUri($(window.parent.location).attr('href')).host;");
            writer.WriteLine("if (AWSHelpObj.showRegionalDisclaimer(host)) {");
            writer.WriteLine("$(\"div#regionDisclaimer\").css(\"display\", \"block\");");
            writer.WriteLine("} else {");
            writer.WriteLine("$(\"div#regionDisclaimer\").remove();");
            writer.WriteLine("}");

            var versionInfoFile = RootRelativePath + "/items/_sdk-versions.json";
            if (isCore)
                writer.WriteLine("AWSHelpObj.setAssemblyVersion(\"{0}\");",
                                 versionInfoFile);
            else
                writer.WriteLine("AWSHelpObj.setAssemblyVersion(\"{0}\", \"{1}\");",
                                 versionInfoFile,
                                 Artifacts.ServiceName);
            writer.WriteLine("});");            
            writer.WriteLine("</script>");
            writer.WriteLine("<!-- END-SECTION -->");
            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/syntaxhighlighter/shCore.js\"></script>", RootRelativePath);
            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/syntaxhighlighter/shBrushCSharp.js\"></script>", RootRelativePath);
            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/syntaxhighlighter/shBrushPlain.js\"></script>", RootRelativePath);
            writer.WriteLine("<script type=\"text/javascript\" src=\"{0}/resources/syntaxhighlighter/shBrushXml.js\"></script>", RootRelativePath);
            writer.WriteLine("<script type=\"text/javascript\">SyntaxHighlighter.all()</script>");
        }

        protected string FormatParameters(IList<ParameterInfoWrapper> infos)
        {
            var sb = new StringBuilder();
            foreach (var info in infos)
            {
                if (sb.Length > 0)
                    sb.Append(", ");

                string parameterTypeName;
                switch (info.ParameterType.FullName)
                {
                    case "System.String":
                        parameterTypeName = "string";
                        break;
                    case "System.Int32":
                        parameterTypeName = "int";
                        break;
                    case "System.Double":
                        parameterTypeName = "double";
                        break;
                    case "System.Float":
                        parameterTypeName = "float";
                        break;
                    case "System.Boolean":
                        parameterTypeName = "bool";
                        break;
                    case "System.Object":
                        parameterTypeName = "object";
                        break;
                    default:
                        parameterTypeName = info.ParameterType.GetDisplayName(false);
                        break;
                }

                sb.AppendFormat("{0}{1}", info.IsOut ? "out " : "", parameterTypeName);
            }
            return sb.ToString();
        }

        protected void AddMemberTableSectionHeader(TextWriter writer, string name, bool showIconColumn = true)
        {
            AddMemberTableSectionHeader(writer, 
                                        name, 
                                        showIconColumn 
                                            ? IconisedNameDescriptionTableColumnHeaders 
                                            : NameDescriptionTableColumnHeaders);
        }

        /// <summary>
        /// Adds a standard member-name/description table with optional type column
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="title"></param>
        /// <param name="columnHeaders"></param>
        protected void AddMemberTableSectionHeader(TextWriter writer, 
                                                   string title, 
                                                   List<TableColumnHeader> columnHeaders)
        {
            writer.WriteLine("<div>");
                writer.WriteLine("<div>");
                    writer.WriteLine("<div class=\"collapsibleSection\">");
                    writer.WriteLine("<h2 id=\"{1}\" class=\"title\">{0}</h2>", title, title.Replace(" ", "").ToLower());
                    writer.WriteLine("</div>");
                writer.WriteLine("</div>");

                writer.WriteLine("<div class=\"sectionbody\">");
                    writer.WriteLine("<table class=\"members\">");
                        writer.WriteLine("<tbody>");
                        writer.WriteLine("<tr>");

                        foreach (var ch in columnHeaders)
                        {
                            writer.Write("<th");
                            if (!string.IsNullOrEmpty(ch.Id))
                                writer.Write(" id=\"{0}\"", ch.Id);
                            if (!string.IsNullOrEmpty(ch.CssClass))
                                writer.Write(" class=\"{0}\"", ch.CssClass);
                            writer.Write(">");
                            if (!string.IsNullOrEmpty(ch.Title))
                                writer.Write(ch.Title);
                            writer.Write("</th>");
                        }
                        writer.WriteLine("</tr>");
        }

        protected void AddMemberTableSectionClosing(TextWriter writer)
        {
                        writer.WriteLine("</tbody>");
                    writer.WriteLine("</table>");
                writer.WriteLine("</div>");
            writer.WriteLine("</div>");
        }

        protected void AddSectionHeader(TextWriter writer, string name)
        {
            writer.WriteLine("<div>");
                writer.WriteLine("<div>");
                    writer.WriteLine("<div class=\"collapsibleSection\">");
                        writer.WriteLine("<h2 id=\"{1}\" class=\"title\">{0}</h2>", name, name.Replace(" ", "").ToLower());
                    writer.WriteLine("</div>");
                writer.WriteLine("</div>");

                writer.WriteLine("<div class=\"sectionbody\">");
        }

        protected void AddSectionClosing(TextWriter writer)
        {
                writer.WriteLine("</div>");
            writer.WriteLine("</div>");
        }

        protected void AddSummaryDocumentation(TextWriter writer)
        {
            writer.WriteLine("<div id=\"summaryblock\">");

            var element = GetSummaryDocumentation();
            if (element != null)
            {
                var htmlDocs = NDocUtilities.TransformDocumentationToHTML(element, "summary", TypeProvider, this._version);
                writer.WriteLine(htmlDocs);

                AddSummaryNotes(writer);
            }

            writer.WriteLine("</div>");
        }

        protected void AddRemarksDocumentation(TextWriter writer)
        {
            var element = GetSummaryDocumentation();
            if (element != null)
            {
                var htmlDocs = NDocUtilities.TransformDocumentationToHTML(element, "remarks", TypeProvider, this._version);
                if (string.IsNullOrEmpty(htmlDocs))
                    return;

                AddSectionHeader(writer, "Remarks");
                writer.WriteLine(htmlDocs);
                AddSectionClosing(writer);
            }
        }

        protected void AddExamples(TextWriter writer)
        {
            var element = GetSummaryDocumentation();
            if (element != null)
            {
                var htmlDocs = NDocUtilities.TransformDocumentationToHTML(element, "example", TypeProvider, this._version);
                if (string.IsNullOrEmpty(htmlDocs))
                    return;

                AddSectionHeader(writer, "Examples");
                writer.WriteLine(htmlDocs);
                AddSectionClosing(writer);
            }
        }

        protected void AddSeeAlso(TextWriter writer)
        {
            var element = GetSummaryDocumentation();
            if (element != null)
            {
                var htmlDocs = NDocUtilities.TransformDocumentationToHTML(element, "seealso", TypeProvider, this._version);
                if (string.IsNullOrEmpty(htmlDocs))
                    return;

                AddSectionHeader(writer, "See Also");
                writer.WriteLine(htmlDocs);
                AddSectionClosing(writer);
            }
        }

        protected void AddNamespace(TextWriter writer, string ns, string moduleName)
        {
            writer.WriteLine("<div id=\"namespaceblock\">");
                writer.Write("<p>");
                writer.Write("<strong>Namespace: </strong>{0}<br/>", ns);
                writer.Write("<strong>Assembly: </strong>{0}", moduleName);
                writer.Write("<span id=\"versionData\">");
                writer.Write("<br/><strong>Version: </strong><span id=\"assemblyVersion\">3.x.y.z</span>");
                writer.Write("</span>");
                writer.Write("</p>");
            writer.WriteLine("</div>");
        }

        protected void AddVersionInformation(TextWriter writer, AbstractWrapper wrapper)
        {
            AddSectionHeader(writer, "Version Information");
            
            var docs472 = NDocUtilities.FindDocumentation(Artifacts.NDocForPlatform("net472"), wrapper, TypeProvider);
            var docsCore20 = NDocUtilities.FindDocumentation(Artifacts.NDocForPlatform("netstandard2.0"), wrapper, TypeProvider);
            var docsNetCoreApp31 = NDocUtilities.FindDocumentation(Artifacts.NDocForPlatform("netcoreapp3.1"), wrapper, TypeProvider);
            var docsNet80 = NDocUtilities.FindDocumentation(Artifacts.NDocForPlatform("net8.0"), wrapper, TypeProvider);

            // If there is no documentation then assume it is available for all platforms.
            var boolNoDocs = docs472 == null && docsCore20 == null && docsNetCoreApp31 == null
                && docsNet80 == null;

            // .NET Core / .NET
            var netAppVersions = new List<string>();

            if (boolNoDocs || (wrapper != null && docsNet80 != null))
                netAppVersions.Add("8.0 and newer");

            if (boolNoDocs || (wrapper != null && docsNetCoreApp31 != null))
                netAppVersions.Add("Core 3.1");

            if (netAppVersions.Count > 0)
            {
                writer.WriteLine("<p><strong>.NET: </strong><br/>Supported in: {0}<br/>", string.Join(", ", netAppVersions));
            }

            // .NET Standard
            var netstandardVersions = new List<string>();            
            if (boolNoDocs || (wrapper != null && docsCore20 != null))
                netstandardVersions.Add("2.0");            

            if(netstandardVersions.Count > 0)
            {
                writer.WriteLine("<p><strong>.NET Standard: </strong><br/>Supported in: {0}<br/>", string.Join(", ", netstandardVersions));
            }

            // .NET Framework
            var netframeworkVersions = new List<string>();
            if (boolNoDocs || (wrapper != null && docs472 != null))
                netframeworkVersions.Add("4.7.2 and newer");

            if (netframeworkVersions.Count > 0)
            {
                writer.WriteLine("<p><strong>.NET Framework: </strong><br/>Supported in: {0}<br/>", string.Join(", ", netframeworkVersions));
            }                        

            AddSectionClosing(writer);
        }

        protected void AddSyntax(TextWriter writer, string csharpSyntax)
        {
            if (string.IsNullOrEmpty(csharpSyntax))
                return;

            AddSectionHeader(writer, "Syntax");

            writer.WriteLine("<div class=\"codeSnippetContainer\">");

                writer.WriteLine("<div class=\"codeSnippetContainerTabs\">");
                    writer.WriteLine("<div class=\"codeSnippetContainerTabActive\">");
                        writer.WriteLine("<a class=\"languageTabLabel\">C#</a>");
                    writer.WriteLine("</div>");
                writer.WriteLine("</div>");

                writer.WriteLine("<div class=\"codeSnippetContainerCodeContainer\">");
                    writer.WriteLine("<div style=\"color:Black;\">");
                        writer.WriteLine("<pre class=\"syntax\">{0}</pre>", csharpSyntax);
                    writer.WriteLine("</div>");
                writer.WriteLine("</div>");

            writer.WriteLine("</div>");

            AddSectionClosing(writer);
        }

        public static string GetCrossReferenceTypeName(XElement element)
        {
            var node = element.Attribute("cref");
            if (node == null)
                return null;

            var typeName = node.Value;
            return typeName;
        }

        public void WriteCrossReferenceTagReplacement(TextWriter writer, string typeName)
        {
            var replacement = CreateCrossReferenceTagReplacement(TypeProvider, typeName, this._version);
            writer.Write(replacement);
        }

        public static string CreateCrossReferenceTagReplacement(AbstractTypeProvider typeProvider, string crefTypeName, FrameworkVersion version)
        {
            const string amazonNamespaceRoot = "Amazon.";

            var target = string.Empty;
            string url = null;

            string typeName;
            if (crefTypeName.Length > 2 && crefTypeName[1] == ':') // cref M:, T:, P:, F: indicators
                typeName = crefTypeName.Substring(2);
            else
                typeName = crefTypeName;

            var typeWrapper = typeProvider.GetType(typeName);

            if (typeWrapper != null)
                url = string.Format("./{0}", FilenameGenerator.GenerateFilename(typeWrapper));
            else if (typeName.StartsWith("system.", StringComparison.OrdinalIgnoreCase))
            {
                url = string.Format(NDocUtilities.MSDN_TYPE_URL_PATTERN, typeName.ToLower());
                target = "target=_new";
            }

            // If we couldn't generate a url to use with an anchor tag, make the typename italic+bold so
            // that it at least stands out. 
            if (url == null)
                return string.Format("<i><b>{0}</b></i>", typeName);

            // If the type is one of ours, strip the namespace from the display text to condense things
            // a little
            if (typeName.StartsWith(amazonNamespaceRoot, StringComparison.Ordinal))
            {
                var lastPeriodIndex = typeName.LastIndexOf('.');
                typeName = typeName.Substring(lastPeriodIndex + 1);
            }

            return string.Format("<a href=\"{0}\" {2} rel=\"noopener noreferrer\">{1}</a>", url, typeName, target);
        }
    }

    /// <summary>
    /// Used to build ordered collections of table headers used in the various
    /// sections of a page. Custom css (as id or class) can optionally be applied.
    /// </summary>
    public class TableColumnHeader
    {
        /// <summary>
        /// The colum header displayed to the user. If not specified the column
        /// will have a blank title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// if set, applied as an 'id' attribute on the resulting td element
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// If set, applied as a 'class' attribute on the resulting td element
        /// </summary>
        public string CssClass { get; set; }
    }
}
