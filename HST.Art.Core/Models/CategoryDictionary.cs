/**  版本信息模板在安装目录下，可自行修改。
* CategoryDictionary.cs
*
* 功 能： N/A
* 类 名： CategoryDictionary
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/4/14 19:04:29   N/A    初版
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
	/// CategoryDictionary:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CategoryDictionary
	{
		public CategoryDictionary()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _parent;
		private string _name;
		private int _state;
		private DateTime _createdate= DateTime.Now;
		private bool _isdeleted= false;
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
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Parent
		{
			set{ _parent=value;}
			get{return _parent;}
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
		/// 0:??
	///   1:??
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDeleted
		{
			set{ _isdeleted=value;}
			get{return _isdeleted;}
		}
		#endregion Model

	}
}

