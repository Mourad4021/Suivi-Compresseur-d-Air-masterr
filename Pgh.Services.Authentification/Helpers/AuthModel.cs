using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Pgh.Services.Authentification.Helpers
{
    public class AuthModelDto
    {
        [JsonProperty("Token_Attribute")]
        public JwtToken Token { get; set; }
        [JsonProperty("Nom_Utilisateur")]
        public string UserName { get; set; }
        [JsonProperty("Code_Utilisateur")]
        public string UserLogin { get; set; }
        [JsonProperty("Nom_Application")]
        public string Application { get; set; }
        [JsonProperty("Code_Application")]
        public string AppCode { get; set; }
        [JsonProperty("Liste_des_permissions")]
        public List<MenuPermission> MenuPermissions { get; set; }

    }

    public class MenuPermission
    {
        [JsonProperty("Menu Nom")]
        public string MenuName { get; set; }
        [JsonProperty("Menu Url")]
        public string MenuUrl { get; set; }
        [JsonProperty("Menu ID")]
        public Guid MenuId { get; set; }
        [JsonProperty("Menu Parent ID")]
        public Guid? MenuParentId { get; set; }
        [JsonProperty("Détails des permissions")]
        public List<PermissionDetail> PermissionDetails { get; set; }
    }

    public class PermissionDetail
    {
        [JsonProperty("Permission Nom")]
        public string PermissionName { get; set; }
        [JsonProperty("Permission ID")]
        public Guid PermissionId { get; set; }

        [JsonProperty("Groupe Nom")]
        public string GroupeName { get; set; }
        [JsonProperty("Groupe ID")]
        public Guid? GroupeId { get; set; }
    }
    
}