namespace FmgLib.MauiMarkup;

public static class VisualStateGroupListExtension
{
    public static VisualStateGroup GetCommonStatesVisualStateGroupFmg(this VisualStateGroupList self)
    {
        VisualStateGroup visualStateGroup = self.FirstOrDefault((VisualStateGroup e) => e.Name.Equals("CommonStates"));
        if (visualStateGroup == null)
        {
            visualStateGroup = new VisualStateGroup
            {
                Name = "CommonStates"
            };
            self.Add(visualStateGroup);
        }

        return visualStateGroup;
    }

    public static void AddFmg(this VisualStateGroupList self, VisualState visualState)
    {
        self.GetCommonStatesVisualStateGroupFmg().States.Add(visualState);
    }
}