/**  版本信息模板在安装目录下，可自行修改。
* Organization.cs
*
* 功 能： N/A
* 类 名： Organization
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/4/14 19:04:32   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace HST.Art.Model
{
	/// <summary>
	/// Organization:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Organization
	{
		public Organization()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _logo;
		private string _telephone;
		private string _email;
		private string _wechat;
		private string _blog;
		private string _description;
		private string _framework;
		private DateTime _createdate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WeChat
		{
			set{ _wechat=value;}
			get{return _wechat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Blog
		{
			set{ _blog=value;}
			get{return _blog;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Framework
		{
			set{ _framework=value;}
			get{return _framework;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		#endregion Model

	}
}

