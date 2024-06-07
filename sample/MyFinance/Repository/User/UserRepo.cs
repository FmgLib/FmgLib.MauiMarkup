
namespace MyFinance.Repository;

public class UserRepo(MyFinanceContext context) : Repo<User>(context), IUserRepo
{ }
