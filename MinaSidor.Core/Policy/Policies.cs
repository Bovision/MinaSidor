namespace MinaSidor.Core.Policy;

public static class Policies
{
    public const string Default = "Default";
    public const string IsAgent = "IsAgent";
    public const string IsOfficeAdmin = "IsOfficeAdmin";
    public const string IsOfficeAdminOrAdministrator = "IsOfficeAdminOrAdmin";
    public const string HasAdministratorPermission = "HasAdministratorPermission";
    /// <summary>
    /// Policy that determines whether user can view Agents enrollments.
    /// Allows OfficeAdmins and administrators to view all enrollments and other users to view
    /// only their own enrollments.
    /// </summary>
    public const string CanViewAgentEnrollments = "CanViewAgentEnrollments";
}
