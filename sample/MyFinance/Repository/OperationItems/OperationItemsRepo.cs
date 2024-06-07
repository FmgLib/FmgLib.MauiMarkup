
namespace MyFinance.Repository;

public class OperationItemsRepo(MyFinanceContext context) : Repo<OperationItem>(context), IOperationItemsRepo
{
}
