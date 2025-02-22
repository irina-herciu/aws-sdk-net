﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\SourceFiles\CoreAssemblyInfo.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CoreAssemblyInfo : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Reflection;\r\nusing System.Runtime.InteropServices;\r" +
                    "\nusing System.Runtime.CompilerServices;\r\n\r\n// General Information about an assem" +
                    "bly is controlled through the following \r\n// set of attributes. Change these att" +
                    "ribute values to modify the information\r\n// associated with an assembly.\r\n[assem" +
                    "bly: AssemblyTitle(\"AWSSDK.Core\")]\r\n#if BCL35\r\n[assembly: AssemblyDescription(\"T" +
                    "he Amazon Web Services SDK for .NET (3.5) - Core Runtime\")]\r\n#elif BCL45\r\n[assem" +
                    "bly: AssemblyDescription(\"The Amazon Web Services SDK for .NET (4.5) - Core Runt" +
                    "ime\")]\r\n#elif NETSTANDARD20\r\n[assembly: AssemblyDescription(\"The Amazon Web Serv" +
                    "ices SDK for .NET (NetStandard 2.0) - Core Runtime\")]\r\n#elif NETCOREAPP3_1\r\n[ass" +
                    "embly: AssemblyDescription(\"The Amazon Web Services SDK for .NET (.NET Core 3.1)" +
                    " - Core Runtime\")]\r\n#elif NET8_0\r\n[assembly: AssemblyDescription(\"The Amazon Web" +
                    " Services SDK for .NET (.NET 8.0) - Core Runtime\")]\r\n#else\r\n#error Unknown platf" +
                    "orm constant - unable to set correct AssemblyDescription\r\n#endif\r\n[assembly: Int" +
                    "ernalsVisibleTo(\"AWSSDK.UnitTests.Net45, PublicKey=00240000048000009400000006020" +
                    "00000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc74ab17ba9a9d" +
                    "f0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc55859b0d09" +
                    "d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977900eddbf12" +
                    "52ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4\")]\r\n[assembly: InternalsVisi" +
                    "bleTo(\"AWSSDK.UnitTests.Net35, PublicKey=002400000480000094000000060200000024000" +
                    "0525341310004000001000100db5f59f098d27276c7833875a6263a3cc74ab17ba9a9df0b52aedbe" +
                    "7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc55859b0d09d3bc0a84ee" +
                    "cd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977900eddbf1252ed08a241" +
                    "3f00a28f3a0752a81203f03ccb7f684db373518b4\")]\r\n// Assembly name of UnitTests.NetS" +
                    "tandard\r\n[assembly: InternalsVisibleTo(\"UnitTests, PublicKey=0024000004800000940" +
                    "000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc74" +
                    "ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc" +
                    "55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977" +
                    "900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4\")]\r\n[assembly: Int" +
                    "ernalsVisibleTo(\"AWSSDK.UnitTests.Custom.NetStandard, PublicKey=0024000004800000" +
                    "940000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3c" +
                    "c74ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c" +
                    "8fc55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762" +
                    "977900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4\")]\r\n[assembly: " +
                    "InternalsVisibleTo(\"UnitTests.NetStandard.CoreOnly, PublicKey=002400000480000094" +
                    "0000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc7" +
                    "4ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8f" +
                    "c55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c362276297" +
                    "7900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4\")]\r\n// Allows moq" +
                    " to access internals for testing\r\n[assembly: InternalsVisibleTo(\"DynamicProxyGen" +
                    "Assembly2, PublicKey=00240000048000009400000006020000002400005253413100040000010" +
                    "00100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b9" +
                    "3bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e" +
                    "2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a" +
                    "7d3113e92484cf7045cc7\")]\r\n[assembly: AssemblyConfiguration(\"\")]\r\n[assembly: Asse" +
                    "mblyProduct(\"Amazon Web Services SDK for .NET\")]\r\n[assembly: AssemblyCompany(\"Am" +
                    "azon.com, Inc\")]\r\n[assembly: AssemblyCopyright(\"Copyright Amazon.com, Inc. or it" +
                    "s affiliates. All Rights Reserved.\")]\r\n[assembly: AssemblyTrademark(\"\")]\r\n[assem" +
                    "bly: AssemblyCulture(\"\")]\r\n\r\n// Setting ComVisible to false makes the types in t" +
                    "his assembly not visible \r\n// to COM components.  If you need to access a type i" +
                    "n this assembly from \r\n// COM, set the ComVisible attribute to true on that type" +
                    ".\r\n[assembly: ComVisible(false)]\r\n\r\n// Version information for an assembly consi" +
                    "sts of the following four values:\r\n//\r\n//      Major Version\r\n//      Minor Vers" +
                    "ion \r\n//      Build Number\r\n//      Revision\r\n//\r\n// You can specify all the val" +
                    "ues or you can default the Build and Revision Numbers \r\n// by using the \'*\' as s" +
                    "hown below:\r\n// [assembly: AssemblyVersion(\"1.0.*\")]\r\n[assembly: AssemblyVersion" +
                    "(\"");
            
            #line 56 "C:\Dev\repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\SourceFiles\CoreAssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["Version"]));
            
            #line default
            #line hidden
            this.Write("\")]\r\n[assembly: AssemblyFileVersion(\"");
            
            #line 57 "C:\Dev\repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\SourceFiles\CoreAssemblyInfo.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["FileVersion"]));
            
            #line default
            #line hidden
            this.Write(@""")]

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif

#if BCL45
// Setting SecurityRules to level 1 to match .NET 2.0 rules and allow the
// Amazon.Util.Settings.UserCrypto methods to work in .NET 4.5
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
#endif");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
