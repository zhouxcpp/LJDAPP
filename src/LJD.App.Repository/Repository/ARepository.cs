﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//     生成时间 2019-05-27 09:23:46 by Jelly
//     对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using LJD.App.Model.DbModels;
using LJD.App.Repository.IRepository;

namespace LJD.App.Repository.Repository
{    
          
         
        /// <summary>
        /// 
        /// </summary>        
        public partial class PostRepository : BaseRepository<Post>, IPostRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public PostRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 角色菜单权限按钮关联表
        /// </summary>        
        public partial class R_RolePermissionRepository : BaseRepository<R_RolePermission>, IR_RolePermissionRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public R_RolePermissionRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 用户和角色关联表
        /// </summary>        
        public partial class R_sysUserInfo_sysRoleRepository : BaseRepository<R_sysUserInfo_sysRole>, IR_sysUserInfo_sysRoleRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public R_sysUserInfo_sysRoleRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 用户菜单权限按钮关联表
        /// </summary>        
        public partial class R_UserPermissionsRepository : BaseRepository<R_UserPermissions>, IR_UserPermissionsRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public R_UserPermissionsRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 菜单按钮表
        /// </summary>        
        public partial class SysFunctionRepository : BaseRepository<SysFunction>, ISysFunctionRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public SysFunctionRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 菜单表
        /// </summary>        
        public partial class SysMenusRepository : BaseRepository<SysMenus>, ISysMenusRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public SysMenusRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 组织单位表(部门表)
        /// </summary>        
        public partial class SysOrganizationUnitRepository : BaseRepository<SysOrganizationUnit>, ISysOrganizationUnitRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public SysOrganizationUnitRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 角色表
        /// </summary>        
        public partial class SysRoleRepository : BaseRepository<SysRole>, ISysRoleRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public SysRoleRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 用户表
        /// </summary>        
        public partial class SysUserInfoRepository : BaseRepository<SysUserInfo>, ISysUserInfoRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public SysUserInfoRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
         
        /// <summary>
        /// 流程分类表
        /// </summary>        
        public partial class WfInstanceTypeRepository : BaseRepository<WfInstanceType>, IWfInstanceTypeRepository
        {
            private readonly LJDAPPContext _ljdAppContext;

            public WfInstanceTypeRepository(LJDAPPContext ljdAppContext) : base(ljdAppContext)
            {
                _ljdAppContext = ljdAppContext;
            }
        }
            


} 