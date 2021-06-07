using RESTAPP.Model;
using RESTAPP.ViewPage.Mainviews.MenuComponents;
using System.Collections.Generic;
using Xam.TabView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RESTAPP.ViewPage.Mainviews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            list1.ItemsSource = new List<MenuList>() {
                new MenuList()
                {
                    menuList = "Key lime pie",
                    priceList = "$10",
                    Image = "https://cdn.shortpixel.ai/client/q_glossy,ret_img,w_660/https://www.thatskinnychickcanbake.com/wp-content/uploads/2017/02/Key-Lime-Pie-with-Graham-Cracker-Crust-6-Copy-1-660x440.jpg",
                    ingredients = "Classic Key Lime Pie with a citrus filling nestled in a graham cracker crust. cups graham cracker crumbs, tablespoons sugar, tablespoons butter, melted, can sweetned condensed milk, egg yolks"
                },
                new MenuList()
                {
                    menuList = "Tater Tots",
                    priceList = "$15",
                    Image = "https://static01.nyt.com/images/2017/05/16/dining/16COOKING-TATERTOTS2/16COOKING-TATERTOTS2-articleLarge.jpg",
                    ingredients = "There's no need to peel the new potatoes for these otherwise labor-intensive tots, which are little"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "French Onion Soup",
                    priceList = "$7"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
                new MenuList()
                {
                    menuList = "Yello Dai TadKa",
                    priceList = "$10",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQnD5irX112Wgy7XYgrUibl3RYSrUfqa29XQYhBRtZ5SYS9nB_c",
                    ingredients = "Our classic 1 Lb rounds are the perfect accompaniment to any meal, or slice for delicious sandwiches. Another great product brought to you from San"
                },
            };
            list2.ItemsSource = new List<MenuList>()
            {
                new MenuList()
                {
                    menuList = "Black Forest Gateau",
                    priceList = "$10",
                    Image = "https://food-images.files.bbci.co.uk/food/recipes/black_forest_gateau_43895_16x9.jpg",
                    ingredients = "Rich with fruit, chocolate and cream, this 70s classic still has a place on our tables."
                },
                new MenuList()
                {
                    menuList = "Pineapple Cake",
                    priceList = "$15",
                    Image = "https://browncreams.com/wp-content/uploads/2019/01/pineapple-cake-online-order-guawhati.jpg",
                    ingredients = "Rich Vanilla Sponge Base With Whipped Cream And Chunks Filling The Inside And Pineapple Slices On The Outside. Decorated With Pineapple Glaze "
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                },
                new MenuList()
                {
                    menuList = "Oreo Cheesecake",
                    priceList = "$25",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRjkpKKWF0aPjNHuAzpibiRhIvTnjOlz9k98Gvo6mhrpsEHaXEK",
                    ingredients = "If you love Oreos and cheesecake on their own, you're going to flip over this dessert,! oreo cookie, divided, plus extra for garnish, butter, melted, cream cheese, room temperature, teaspoon vanilla"
                }
            };
            list3.ItemsSource = new List<MenuList>()
            {
                new MenuList()
                {
                    menuList = "Caffè Americano",
                    priceList = "$5",
                    Image = "http://miriamscoffee.com/wp-content/uploads/2018/05/Cafe-Americano.jpg",
                    ingredients = "Long black coffee made with shots of espresso. In every drop you can taste the superior quality of Arabica coffee beans, which gives our Americano"
                },
                new MenuList()
                {
                    menuList = "Cappuccino",
                    priceList = "$10",
                    Image = "https://www.nespresso.com/ncp/res/uploads/recipes/nespresso-recipes-CAPPUCCINO-BANANA-SESAME-SEEDS.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                },
                new MenuList()
                {
                    menuList = "Flat White",
                    priceList = "$15",
                    Image = "https://afar-production.imgix.net/uploads/images/afar_post_headers/images/xkmB2uepVe/original_pexels-photo-312420.jpg",
                    ingredients = "Let's discover all our tastiest Nespresso recipes, Banana Syrup, Milk, Dried Banana Chips, Sesame seeds"
                }
            };
            list4.ItemsSource = new List<MenuList>()
            {
                new MenuList()
                {
                    menuList = "Martini",
                    priceList = "$3",
                    Image = "https://icdn2.themanual.com/image/themanual/vodka-martini-olives-glass.jpg",
                    ingredients = "Of the many martini recipes, there is only one dry gin martini. Discover how to make the classic, Ounces gin, ounce dry vermouth, a lemon twist, angostura bitters"
                },
                new MenuList()
                {
                    menuList = "Manhattan",
                    priceList = "$5",
                    Image = "https://www.remymartin.com/wp-content/uploads/2017/01/62_Manhattan-1-1024x524.jpg",
                    ingredients = "This regal drink is part of a collection of cocktails named after New York City’s five boroughs"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                },
                new MenuList()
                {
                    menuList = "Bloody Mary",
                    priceList = "$7",
                    Image = "https://www.goya.com/media/3161/kicking-bloody-mary.jpg?quality=80",
                    ingredients = "Bam! Now that’s good. Treat your holiday guests to this amazing, palate-awakening Bloody Mary made, sodium tomato, vodka"
                }
            };
        }
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var txt = e.SelectedItem as MenuList;
            await Navigation.PushAsync(new MenuDetails(txt.menuList, txt.priceList, txt.Image, txt.ingredients));
        }

        private XFTabControl createTab()
        {
            XFTabControl tab = new XFTabControl();
            tab.TabClicked += XFTabControl_TabClicked;
            return tab;
        }
        private void XFTabControl_TabClicked(object sender, Xam.TabView.OnTabClickedEventArgs args)
        {

        }
    }
}