﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class WrappingResultGenerator : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Xml.Serialization;" +
                    "\r\nusing System.Text;\r\nusing System.IO;\r\n\r\nusing Amazon.Runtime;\r\nusing Amazon.Ru" +
                    "ntime.Internal;\r\n\r\nnamespace ");
            
            #line 18 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n    /// <summary>\r\n    /// Contains the response data from the ");
            
            #line 21 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write(" operation.\r\n    /// </summary>\r\n\tpublic partial class ");
            
            #line 23 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 23 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseClass));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n        private ");
            
            #line 25 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 25 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.VariableName));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n        /// <summary>\r\n\t\t/// Gets and sets the ");
            
            #line 28 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.PropertyName));
            
            #line default
            #line hidden
            this.Write(" member\r\n        /// </summary>\r\n        public ");
            
            #line 30 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 30 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.PropertyName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get { return this.");
            
            #line 32 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.VariableName));
            
            #line default
            #line hidden
            this.Write("; }\r\n            set { this.");
            
            #line 33 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.VariableName));
            
            #line default
            #line hidden
            this.Write(" = value; }\r\n        }\r\n\r\n        // Check to see if ");
            
            #line 36 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.PropertyName));
            
            #line default
            #line hidden
            this.Write(" property is set\r\n        internal bool IsSet");
            
            #line 37 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.PropertyName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n            return this.");
            
            #line 39 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null;\r\n        }\r\n    }\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 45 "C:\dev\codecommit\unityv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\WrappingResultGenerator.tt"

	public Operation Operation { get; set; }
    public string ClassName { get; set; }
    public string BaseClass { get; set; }
    public Shape Structure { get; set; }
	public string VariableName
	{
		get
		{
            string txt = "_" + this.Structure.Name[0].ToString().ToLower();
            if (this.Structure.Name.Length > 1)
                txt += this.Structure.Name.Substring(1);
            return txt;
		}
	}
	public string PropertyName { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
