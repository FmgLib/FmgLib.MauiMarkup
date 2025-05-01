using System.Linq.Expressions;

namespace FmgLib.MauiMarkup;

public class ParameterReplacer : ExpressionVisitor
{
    private readonly ParameterExpression _oldParameter;
    private readonly Expression _newParameter;

    public ParameterReplacer(ParameterExpression oldParameter, Expression newParameter)
    {
        _oldParameter = oldParameter;
        _newParameter = newParameter;
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        return node == _oldParameter ? _newParameter : base.VisitParameter(node);
    }
}