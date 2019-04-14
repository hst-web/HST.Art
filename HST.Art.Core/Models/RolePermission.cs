/*----------------------------------------------------------------
// 文件名：RolePermission.cs
// 功能描述：角色权限信息
// 创建者：sysmenu
// 创建时间：2019-4-14
//----------------------------------------------------------------*/
using System;
namespace HST.Art.Core
{
	/// <summary>
	/// RolePermission
	/// </summary>
	[Serializable]
	public partial class RolePermission
	{
		public RolePermission()
		{}
		#region Model
		private int _id;
		private int _roleid;
		private int _permissionid;
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
		public int RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PermissionId
		{
			set{ _permissionid=value;}
			get{return _permissionid;}
		}
		#endregion Model

	}
}

