namespace CreationalDesignPatterns.Entities.ProtoType
{
    public class AccountPrototypeFactory
    {

        private readonly UserAccount _accountRep;
        private readonly UserAccount _supervisor;

        public AccountPrototypeFactory(UserAccount supervisorAccount, UserAccount arep)
        {
            _accountRep = arep;
            _supervisor = supervisorAccount;
        }

        public UserAccount AccountRep => (UserAccount) _accountRep.Clone();

        public UserAccount Supervisor => (UserAccount) _supervisor.Clone();
    }
}