namespace MauiStudies1;

public partial class MainPage : ContentPage
{
	List<Fruit> fruitList = new List<Fruit>()
	{
		new Fruit(){Name="Apple",ImageName="apple.png",Sentence="it is an apple"},
        new Fruit(){Name="Apricot",ImageName="apricot.png",Sentence="it is an Apricot"},
        new Fruit(){Name="Banana",ImageName="banana.png",Sentence="it is a Banana"},
        new Fruit(){Name="Coconut",ImageName="coconut.png",Sentence="it is a Coconut"},
        new Fruit(){Name="Grape",ImageName="grape.png",Sentence="it is a gropha"},
        new Fruit(){Name="guava",ImageName="guava.png",Sentence="it is a guava"},
        new Fruit(){Name="Kiwi",ImageName="kiwi.png",Sentence="it is a kiwi"},
        new Fruit(){Name="mango",ImageName="mango.png",Sentence="it is a mango"},
        new Fruit(){Name="melon",ImageName="melon.png",Sentence="it is a melon"},
        new Fruit(){Name="orange",ImageName="orange.png",Sentence="it is an orange"},
        new Fruit(){Name="peach",ImageName="peach.png",Sentence="it is a peach"},
        new Fruit(){Name="pear",ImageName="pear.png",Sentence="it is a pear"},
        new Fruit(){Name="pineapple",ImageName="pineapple.png",Sentence="it is a pineapple"},
        new Fruit(){Name="plum",ImageName="plum.png",Sentence="it is a plum"},
        new Fruit(){Name="pomegranate",ImageName="pomegranate.png",Sentence="it is a pomegrante"},
        new Fruit(){Name="strawberry",ImageName="strawberry.png",Sentence="it is a strawberry"},
        new Fruit(){Name="watermelon",ImageName="watermelon.png",Sentence="it is a watermelon"}

    };
	 

	public MainPage()
	{
		InitializeComponent();
        LvFruits.ItemsSource = fruitList;
	}

    private void LvFruits_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selecteditem= e.CurrentSelection.FirstOrDefault() as Fruit;
        if (selecteditem != null)
        Navigation.PushAsync(new FruitDetailPage(selecteditem));
        ((CollectionView)sender).SelectedItem = null;

    }

    //for list view 
    //private void LvFruits_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    //{
    //    var selectedItem = e.SelectedItem as Fruit;
    //    Navigation.PushAsync(new FruitDetailPage(selectedItem));
    //}
}

