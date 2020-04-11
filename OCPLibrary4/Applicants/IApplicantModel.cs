namespace OCPLibrary4
{
    public interface IApplicantModel
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        IAccounts AccountProcessor { get; set; }
    }
}