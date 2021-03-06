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
	/// <summary>Product Detail</summary>
	[PublishedModel("productDetail")]
	public partial class ProductDetail : PublishedContentModel, IOpenGraph, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "productDetail";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProductDetail, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ProductDetail(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Category
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("category")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent> Category => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>>("category");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("description")]
		public global::System.Web.IHtmlString Description => this.Value<global::System.Web.IHtmlString>("description");

		///<summary>
		/// Display Price
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("displayPrice")]
		public int DisplayPrice => this.Value<int>("displayPrice");

		///<summary>
		/// Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("images")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent> Images => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>>("images");

		///<summary>
		/// Product Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("productName")]
		public string ProductName => this.Value<string>("productName");

		///<summary>
		/// Related Products
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("relatedProducts")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent> RelatedProducts => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>>("relatedProducts");

		///<summary>
		/// Specifications
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("specifications")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ProductSpecification> Specifications => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ProductSpecification>>("specifications");

		///<summary>
		/// Short Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("subDescription")]
		public string SubDescription => this.Value<string>("subDescription");

		///<summary>
		/// Tags
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("tags")]
		public global::System.Collections.Generic.IEnumerable<string> Tags => this.Value<global::System.Collections.Generic.IEnumerable<string>>("tags");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("image")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Image => global::Umbraco.Web.PublishedModels.OpenGraph.GetImage(this);

		///<summary>
		/// Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("link")]
		public string Link => global::Umbraco.Web.PublishedModels.OpenGraph.GetLink(this);

		///<summary>
		/// Short Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("shortDescription")]
		public global::System.Web.IHtmlString ShortDescription => global::Umbraco.Web.PublishedModels.OpenGraph.GetShortDescription(this);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("title")]
		public string Title => global::Umbraco.Web.PublishedModels.OpenGraph.GetTitle(this);

		///<summary>
		/// Browser Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("browserTitle")]
		public string BrowserTitle => global::Umbraco.Web.PublishedModels.SEO.GetBrowserTitle(this);

		///<summary>
		/// Canonical Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("canonicalLink")]
		public string CanonicalLink => global::Umbraco.Web.PublishedModels.SEO.GetCanonicalLink(this);

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => global::Umbraco.Web.PublishedModels.SEO.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metaKeywords")]
		public global::System.Collections.Generic.IEnumerable<string> MetaKeywords => global::Umbraco.Web.PublishedModels.SEO.GetMetaKeywords(this);

		///<summary>
		/// Meta Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metaName")]
		public string MetaName => global::Umbraco.Web.PublishedModels.SEO.GetMetaName(this);

		///<summary>
		/// Site Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("siteName")]
		public string SiteName => global::Umbraco.Web.PublishedModels.SEO.GetSiteName(this);
	}
}
