﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class EventStreamPublisherMarshaller : BaseMarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

    AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.IO;\r\nusing System.Threading.Tasks;\r\nusing Amazon.Runt" +
                    "ime.EventStreams;\r\n#pragma warning disable CS0612,CS0618\r\nnamespace ");
            
            #line 14 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Marshalles" +
                    " the service events for the event stream to the low level IEventStreamMessage.\r\n" +
                    "    /// </summary>\r\n    public partial class ");
            
            #line 19 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("PublisherMarshaller : EventStreamPublisher\r\n    {\r\n        Func< Task<I");
            
            #line 21 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("Event>> _publisher;\r\n\r\n        /// <summary>\r\n        /// Creates instance of ");
            
            #line 24 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("PublisherMarshaller\r\n        /// </summary>\r\n        /// <param name=\"publisher\">" +
                    "The service event publisher provided by the consumer of the SDK.</param>\r\n      " +
                    "  public ");
            
            #line 27 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("PublisherMarshaller(Func<Task<I");
            
            #line 27 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(@"Event>> publisher)
        {
            _publisher = publisher;
        }

        /// <summary>
        /// Gets the next service event provided by the consumer of the SDK and converts it to a IEventStreamMessage.
        /// </summary>
        /// <returns></returns>
        /// <exception cref=""Amazon.Runtime.AmazonClientException"">If the type of the event is unknown.</exception>
        public override async Task<IEventStreamMessage> NextEventAsync()
        {
            var evnt = await _publisher().ConfigureAwait(false);
            if (evnt == null)
                return null;

            byte[] eventPayload;
            string contentType;
            string eventType;
");
            
            #line 46 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

    for (var i = 0; i < this.Structure.Members.Count; i++)
    {
        var member = this.Structure.Members[i];

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 51 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i > 0 ? "else " : ""));
            
            #line default
            #line hidden
            this.Write("if (evnt is ");
            
            #line 51 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ModelShape.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n            {\r\n                var memoryStream = new MemoryStream();\r\n       " +
                    "         var context = CreateJsonMarshallerContext(memoryStream);\r\n             " +
                    "   context.Writer.WriteStartObject();\r\n                ");
            
            #line 56 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ModelShape.Name));
            
            #line default
            #line hidden
            this.Write("Marshaller.Instance.Marshall((");
            
            #line 56 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ModelShape.Name));
            
            #line default
            #line hidden
            this.Write(")evnt, context);\r\n                context.Writer.WriteEndObject();\r\n             " +
                    "   context.Writer.Flush();\r\n\r\n                eventType = \"");
            
            #line 60 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.EventTypeName));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 61 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

            if (member.ModelShape.GetExplicitEventPayloadMember() != null)
            {
                if (member.ModelShape.GetExplicitEventPayloadMember().IsMemoryStream)
                {

            
            #line default
            #line hidden
            this.Write("                contentType = \"application/octet-stream\";\r\n                eventP" +
                    "ayload = context.Request.Content;\r\n");
            
            #line 69 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

                }
                else
                {

            
            #line default
            #line hidden
            this.Write("                contentType = \"text/plain\";\r\n                eventPayload = conte" +
                    "xt.Request.Content;\r\n");
            
            #line 76 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

                }
            }
            else
            {

            
            #line default
            #line hidden
            this.Write("                contentType = \"application/json\";\r\n                eventPayload =" +
                    " memoryStream.ToArray();\r\n");
            
            #line 84 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

            }

            
            #line default
            #line hidden
            this.Write("            }\r\n");
            
            #line 88 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"            else
            {
                throw new Amazon.Runtime.AmazonClientException($""Type {evnt.GetType().FullName} is not a known event type for this streaming operation"");
            }

            return CreateEventStreamMessage(eventType: eventType, contentType: contentType, marshalledEventHeaders: null, eventPayload: eventPayload);
        }
    }
}
");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 100 "C:\codebase\v4\aws-sdk-net-v4\generator\ServiceClientGeneratorLib\Generators\Marshallers\EventStreamPublisherMarshaller.tt"

    public string ClassName { get; set; }
    public Shape Structure { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
