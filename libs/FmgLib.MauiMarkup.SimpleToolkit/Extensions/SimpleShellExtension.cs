using Microsoft.Maui.Controls;
using SimpleToolkit.Core;
using SimpleToolkit.SimpleShell;
using SimpleToolkit.SimpleShell.Transitions;

namespace FmgLib.MauiMarkup.SimpleToolkit;

public static partial class SimpleShellExtension
{
    public static T ContentFmg<T>(this T self,
        View view)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.ContentProperty, view);
        return self;
    }

    public static T ContentFmg<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<View>(self, SimpleShell.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self,
        View view)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.ContentProperty, Value = view });
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<View>(self.XamlSetters, SimpleShell.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static T RootPageContainerFmg<T>(this T self,
        View rootPageContainer)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.RootPageContainerProperty, rootPageContainer);
        return self;
    }

    public static T RootPageContainerFmg<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<View>(self, SimpleShell.RootPageContainerProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RootPageContainerFmg<T>(this SettersContext<T> self,
        View rootPageContainer)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.RootPageContainerProperty, Value = rootPageContainer });
        return self;
    }

    public static SettersContext<T> RootPageContainerFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<View>(self.XamlSetters, SimpleShell.RootPageContainerProperty);
        configure(context).Build();
        return self;
    }

    public static T CurrentPageFmg<T>(this T self,
        Page currentPage)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.CurrentPageProperty, currentPage);
        return self;
    }

    public static T CurrentPageFmg<T>(this T self, Func<PropertyContext<Page>, IPropertyBuilder<Page>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<Page>(self, SimpleShell.CurrentPageProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CurrentPageFmg<T>(this SettersContext<T> self,
        Page currentPage)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.CurrentPageProperty, Value = currentPage });
        return self;
    }

    public static SettersContext<T> CurrentPageFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Page>, IPropertySettersBuilder<Page>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<Page>(self.XamlSetters, SimpleShell.CurrentPageProperty);
        configure(context).Build();
        return self;
    }

    public static T CurrentShellContentFmg<T>(this T self,
        ShellContent currentShellContent)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.CurrentShellContentProperty, currentShellContent);
        return self;
    }

    public static T CurrentShellContentFmg<T>(this T self, Func<PropertyContext<ShellContent>, IPropertyBuilder<ShellContent>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<ShellContent>(self, SimpleShell.CurrentShellContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CurrentShellContentFmg<T>(this SettersContext<T> self,
        ShellContent currentShellContent)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.CurrentShellContentProperty, Value = currentShellContent });
        return self;
    }

    public static SettersContext<T> CurrentShellContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ShellContent>, IPropertySettersBuilder<ShellContent>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<ShellContent>(self.XamlSetters, SimpleShell.CurrentShellContentProperty);
        configure(context).Build();
        return self;
    }

    public static T CurrentShellSectionFmg<T>(this T self,
        ShellSection currentShellSection)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.CurrentShellSectionProperty, currentShellSection);
        return self;
    }

    public static T CurrentShellSectionFmg<T>(this T self, Func<PropertyContext<ShellSection>, IPropertyBuilder<ShellSection>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<ShellSection>(self, SimpleShell.CurrentShellSectionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CurrentShellSectionFmg<T>(this SettersContext<T> self,
        ShellSection currentShellSection)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.CurrentShellSectionProperty, Value = currentShellSection });
        return self;
    }

    public static SettersContext<T> CurrentShellSectionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ShellSection>, IPropertySettersBuilder<ShellSection>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<ShellSection>(self.XamlSetters, SimpleShell.CurrentShellSectionProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellSectionsFmg<T>(this T self,
        IReadOnlyList<ShellSection> shellSections)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.ShellSectionsProperty, shellSections);
        return self;
    }

    public static T ShellSectionsFmg<T>(this T self, Func<PropertyContext<IReadOnlyList<ShellSection>>, IPropertyBuilder<IReadOnlyList<ShellSection>>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<IReadOnlyList<ShellSection>>(self, SimpleShell.ShellSectionsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellSectionsFmg<T>(this SettersContext<T> self,
        IReadOnlyList<ShellSection> shellSections)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.ShellSectionsProperty, Value = shellSections });
        return self;
    }

    public static SettersContext<T> ShellSectionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IReadOnlyList<ShellSection>>, IPropertySettersBuilder<IReadOnlyList<ShellSection>>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<IReadOnlyList<ShellSection>>(self.XamlSetters, SimpleShell.ShellSectionsProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellContentsFmg<T>(this T self,
        IReadOnlyList<ShellContent> shellContents)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.ShellContentsProperty, shellContents);
        return self;
    }

    public static T ShellContentsFmg<T>(this T self, Func<PropertyContext<IReadOnlyList<ShellContent>>, IPropertyBuilder<IReadOnlyList<ShellContent>>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<IReadOnlyList<ShellContent>>(self, SimpleShell.ShellContentsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellContentsFmg<T>(this SettersContext<T> self,
        IReadOnlyList<ShellContent> shellContents)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.ShellContentsProperty, Value = shellContents });
        return self;
    }

    public static SettersContext<T> ShellContentsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IReadOnlyList<ShellContent>>, IPropertySettersBuilder<IReadOnlyList<ShellContent>>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<IReadOnlyList<ShellContent>>(self.XamlSetters, SimpleShell.ShellContentsProperty);
        configure(context).Build();
        return self;
    }

    public static T FlyoutItemsFmg<T>(this T self,
        IReadOnlyList<FlyoutItem> flyoutContents)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.FlyoutItemsProperty, flyoutContents);
        return self;
    }

    public static T FlyoutItemsFmg<T>(this T self, Func<PropertyContext<IReadOnlyList<FlyoutItem>>, IPropertyBuilder<IReadOnlyList<FlyoutItem>>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<IReadOnlyList<FlyoutItem>>(self, SimpleShell.FlyoutItemsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FlyoutItemsFmg<T>(this SettersContext<T> self,
        IReadOnlyList<FlyoutItem> flyoutContents)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.FlyoutItemsProperty, Value = flyoutContents });
        return self;
    }

    public static SettersContext<T> FlyoutItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IReadOnlyList<FlyoutItem>>, IPropertySettersBuilder<IReadOnlyList<FlyoutItem>>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<IReadOnlyList<FlyoutItem>>(self.XamlSetters, SimpleShell.FlyoutItemsProperty);
        configure(context).Build();
        return self;
    }

    public static T TabBarsFmg<T>(this T self,
        IReadOnlyList<TabBar> tabBars)
        where T : SimpleShell
    {
        self.SetValue(SimpleShell.TabBarsProperty, tabBars);
        return self;
    }

    public static T TabBarsFmg<T>(this T self, Func<PropertyContext<IReadOnlyList<TabBar>>, IPropertyBuilder<IReadOnlyList<TabBar>>> configure)
        where T : SimpleShell
    {
        var context = new PropertyContext<IReadOnlyList<TabBar>>(self, SimpleShell.TabBarsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TabBarsFmg<T>(this SettersContext<T> self,
        IReadOnlyList<TabBar> tabBars)
        where T : SimpleShell
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.TabBarsProperty, Value = tabBars });
        return self;
    }

    public static SettersContext<T> TabBarsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IReadOnlyList<TabBar>>, IPropertySettersBuilder<IReadOnlyList<TabBar>>> configure)
        where T : SimpleShell
    {
        var context = new PropertySettersContext<IReadOnlyList<TabBar>>(self.XamlSetters, SimpleShell.TabBarsProperty);
        configure(context).Build();
        return self;
    }

    public static T TransitionFmg<T>(this T self,
        ISimpleShellTransition transition)
        where T : Page
    {
        self.SetValue(SimpleShell.TransitionProperty, transition);
        return self;
    }

    public static T TransitionFmg<T>(this T self, Func<PropertyContext<ISimpleShellTransition>, IPropertyBuilder<ISimpleShellTransition>> configure)
        where T : Page
    {
        var context = new PropertyContext<ISimpleShellTransition>(self, SimpleShell.TransitionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TransitionFmg<T>(this SettersContext<T> self,
        ISimpleShellTransition transition)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.TransitionProperty, Value = transition });
        return self;
    }

    public static SettersContext<T> TransitionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ISimpleShellTransition>, IPropertySettersBuilder<ISimpleShellTransition>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<ISimpleShellTransition>(self.XamlSetters, SimpleShell.TransitionProperty);
        configure(context).Build();
        return self;
    }

    public static T ShouldAutoDisconnectPageHandlerFmg<T>(this T self,
        bool shouldAutoDisconnectPageHandler)
        where T : Page
    {
        self.SetValue(SimpleShell.ShouldAutoDisconnectPageHandlerProperty, shouldAutoDisconnectPageHandler);
        return self;
    }

    public static T ShouldAutoDisconnectPageHandlerFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertyContext<bool>(self, SimpleShell.ShouldAutoDisconnectPageHandlerProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShouldAutoDisconnectPageHandlerFmg<T>(this SettersContext<T> self,
        bool shouldAutoDisconnectPageHandler)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.ShouldAutoDisconnectPageHandlerProperty, Value = shouldAutoDisconnectPageHandler });
        return self;
    }

    public static SettersContext<T> ShouldAutoDisconnectPageHandlerFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SimpleShell.ShouldAutoDisconnectPageHandlerProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellGroupContainerTemplateFmg<T>(this T self,
        DataTemplate shellGroupContainerTemplate)
        where T : ShellGroupItem
    {
        self.SetValue(SimpleShell.ShellGroupContainerTemplateProperty, shellGroupContainerTemplate);
        return self;
    }

    public static T ShellGroupContainerTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : ShellGroupItem
    {
        var context = new PropertyContext<DataTemplate>(self, SimpleShell.ShellGroupContainerTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellGroupContainerTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate shellGroupContainerTemplate)
        where T : ShellGroupItem
    {
        self.XamlSetters.Add(new Setter { Property = SimpleShell.ShellGroupContainerTemplateProperty, Value = shellGroupContainerTemplate });
        return self;
    }

    public static SettersContext<T> ShellGroupContainerTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : ShellGroupItem
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, SimpleShell.ShellGroupContainerTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellGroupContainerFmg<T>(this T self, IView view) where T : ShellGroupItem
    {
        self.SetValue(SimpleShell.ShellGroupContainerProperty, view);
        return self;
    }

    public static T ShellGroupContainerFmg<T>(this T self, Func<PropertyContext<IView>, IPropertyBuilder<IView>> configure) where T : ShellGroupItem
    {
        PropertyContext<IView> arg = new PropertyContext<IView>(self, SimpleShell.ShellGroupContainerProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ShellGroupContainerFmg<T>(this SettersContext<T> self, IView view) where T : ShellGroupItem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SimpleShell.ShellGroupContainerProperty,
            Value = view
        });
        return self;
    }

    public static SettersContext<T> ShellGroupContainerFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IView>, IPropertySettersBuilder<IView>> configure) where T : ShellGroupItem
    {
        PropertySettersContext<IView> arg = new PropertySettersContext<IView>(self.XamlSetters, SimpleShell.ShellGroupContainerProperty);
        configure(arg).Build();
        return self;
    }
}
