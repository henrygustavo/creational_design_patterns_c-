namespace CreationalDesignPatterns.Entities.ProtoType
{
    public class Permission
    {
        public string Resource { get; set; }
        public string Rights { get; set; }

        public Permission(string res, string access)
        {
            Resource = res;
            Rights = access;
        }

        public virtual object Clone()
        {
            Permission permission = new Permission(this.Resource, this.Rights);
            return permission;
        }

        public override string ToString()
        {
            return Resource + "::" + Rights;
        }
    }
}
