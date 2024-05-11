namespace FmgLib.MauiMarkup;

public static class StyleExtension
{
    public static VisualStateGroupList GetVisualStateGroupList(this Style self)
    {
        VisualStateGroupList visualStateGroupList = null;
        Setter setter = self.Setters.FirstOrDefault((Setter e) => e.Property == VisualStateManager.VisualStateGroupsProperty);
        if (setter != null)
        {
            visualStateGroupList = setter.Value as VisualStateGroupList;
        }

        if (visualStateGroupList == null)
        {
            visualStateGroupList = new VisualStateGroupList();
            Setter item = new Setter
            {
                Property = VisualStateManager.VisualStateGroupsProperty,
                Value = visualStateGroupList
            };
            self.Setters.Add(item);
        }

        return visualStateGroupList;
    }
}
