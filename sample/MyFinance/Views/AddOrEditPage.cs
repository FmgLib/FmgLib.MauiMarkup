
namespace MyFinance.Views;

public partial class AddOrEditPage(AddOrEditPageViewModel viewModel) : FmgLibContentPage<AddOrEditPageViewModel>(viewModel)
{
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.Loading();
    }
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Spacing(10)
            .Padding(new Thickness(25, 15))
            .Children(
                new TextEdit()
                .LabelText("Başlık")
                .Text(e => e.Path("OperationItem.Title")),

                new MultilineEdit()
                .LabelText("Açıklama")
                .Text(e => e.Path("OperationItem.Description")),
                
                new DateEdit()
                .Assign(out var dateEdit)
                .LabelText("Tarih")
                .Date(e => e.Path("OperationItem.Date"))
                .PickerButtonAreaTemplate(() => 
                    new HorizontalStackLayout()
                    .Margin(10)
                    .AlignBottomRight()
                    .Spacing(10)
                    .Children(
                        new Button()
                        .BackgroundColor(Transparent)
                        .TextColor(DeepSkyBlue)
                        .FontAttributes(Bold)
                        .Text("Cancel")
                        .Command(e => e.Path("CancelCommand")),

                        new Button()
                        .BackgroundColor(Transparent)
                        .TextColor(DeepSkyBlue)
                        .FontAttributes(Bold)
                        .Text("OK")
                        .Command(e => e.Path("ConfirmCommand"))
                    )
                ),

                new TextEdit()
                .LabelText("Para Tutarı")
                .Keyboard(Numeric)
                .Text(e => e.Path("OperationItem.Amount")),

                new CheckEdit()
                .Label("Gelir")
                .AlignLeft()
                .IsChecked(e => e.Path("OperationItem.IsIncome")),

                new Button()
                .Text("KAYDET")
                .BackgroundColor(DeepSkyBlue)
                .TextColor(Black)
                .FontSize(15)
                .Command(e => e.Path("SaveCommand")),

                new Button()
                .Text("İPTAL")
                .BackgroundColor(DarkGray)
                .TextColor(White)
                .FontSize(15)
                .Command(e => e.Path("CancelCommand")),

                new GeneralPopup("BİLGİ", "İşlem başarılı oldu. ", "OK", PopupType.Info, okBtnCommand: "CancelCommand")
                .RowSpan(4)
                .IsOpen(e => e.Path("IsInfoPopupShow")),

                new GeneralPopup("HATA", "İşlem sırasında beklenmeyen bir hata oluştu! ", "OK", PopupType.Error)
                .RowSpan(4)
                .IsOpen(e => e.Path("IsErrorPopupShow"))
            )
        );
    }
}
