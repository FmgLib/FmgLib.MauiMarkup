using CommunityToolkit.Maui.Animations;
using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class AnimationBehaviorExtension
{
    public static T AnimateCommandFmg<T>(this T self, Command<CancellationToken> command) where T : AnimationBehavior
    {
        self.SetValue(AnimationBehavior.AnimateCommandProperty, command);
        return self;
    }

    public static T AnimateCommandFmg<T>(this T self, Func<PropertyContext<Command<CancellationToken>>, IPropertyBuilder<Command<CancellationToken>>> configure) where T : AnimationBehavior
    {
        PropertyContext<Command<CancellationToken>> arg = new PropertyContext<Command<CancellationToken>>(self, AnimationBehavior.AnimateCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AnimateCommandFmg<T>(this SettersContext<T> self, Command<CancellationToken> command) where T : AnimationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AnimationBehavior.AnimateCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> AnimateCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Command<CancellationToken>>, IPropertySettersBuilder<Command<CancellationToken>>> configure) where T : AnimationBehavior
    {
        PropertySettersContext<Command<CancellationToken>> arg = new PropertySettersContext<Command<CancellationToken>>(self.XamlSetters, AnimationBehavior.AnimateCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T AnimationTypeFmg<T>(this T self, BaseAnimation animation) where T : AnimationBehavior
    {
        self.SetValue(AnimationBehavior.AnimationTypeProperty, animation);
        return self;
    }

    public static T AnimationTypeFmg<T>(this T self, Func<PropertyContext<BaseAnimation>, IPropertyBuilder<BaseAnimation>> configure) where T : AnimationBehavior
    {
        PropertyContext<BaseAnimation> arg = new PropertyContext<BaseAnimation>(self, AnimationBehavior.AnimationTypeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AnimationTypeFmg<T>(this SettersContext<T> self, BaseAnimation animation) where T : AnimationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AnimationBehavior.AnimationTypeProperty,
            Value = animation
        });
        return self;
    }

    public static SettersContext<T> AnimationTypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<BaseAnimation>, IPropertySettersBuilder<BaseAnimation>> configure) where T : AnimationBehavior
    {
        PropertySettersContext<BaseAnimation> arg = new PropertySettersContext<BaseAnimation>(self.XamlSetters, AnimationBehavior.AnimationTypeProperty);
        configure(arg).Build();
        return self;
    }
}
