//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("address")]
		public string Address => this.Value<string>("address");

		///<summary>
		/// Banner
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("banner")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent> Banner => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>>("banner");

		///<summary>
		/// Categories
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("categories")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject> Categories => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject>>("categories");

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("email")]
		public string Email => this.Value<string>("email");

		///<summary>
		/// Information
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("information")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject> Information => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject>>("information");

		///<summary>
		/// Logo Website
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("logoWebsite")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent LogoWebsite => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("logoWebsite");

		///<summary>
		/// Menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("menu")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject> Menu => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject>>("menu");

		///<summary>
		/// My Account
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("myAccount")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject> MyAccount => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.CommonObject>>("myAccount");

		///<summary>
		/// Phone Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("phoneNumber")]
		public string PhoneNumber => this.Value<string>("phoneNumber");

		///<summary>
		/// Social Media
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("socialMedia")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.SocialMedia> SocialMedia => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.SocialMedia>>("socialMedia");

		///<summary>
		/// Website Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("websiteName")]
		public string WebsiteName => this.Value<string>("websiteName");
	}
}