namespace FmgLib.MauiMarkup;

public static partial class BindingConditionExtension
{
    public static BindingCondition Binding(this BindingCondition self, Func<Binding, Binding> bindingBuilder)
    {
        self.Binding = bindingBuilder(new Binding());
        return self;
    }

    public static BindingCondition Binding(this BindingCondition self, BindingBase binding)
    {
        self.Binding = binding;
        return self;
    }

    public static BindingCondition Value(this BindingCondition self, object value)
    {
        self.Value = value;
        return self;
    }

}