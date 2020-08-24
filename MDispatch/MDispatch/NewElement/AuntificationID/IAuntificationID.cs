using MDispatch.NewElement.AuntificationID;

namespace MDispatch.NewElement.AuntificationID
{
    public interface IAuntificationID
    {
        string BiometryType { get; set; }
        bool IsCanceleUI { get; set; }
        void GetAuthenticationMethod();
        void Authentication();
    }
}
