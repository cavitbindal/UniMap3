using Maui.GoogleMaps;

namespace UniMap3;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        List<PinModel> pinList = new List<PinModel>();
        pinList.Add(new PinModel { Latitude = 37.05777417090488, Longitude = 35.354873687891185, Title = "Rektörlük İdari Birimler" });
        pinList.Add(new PinModel { Latitude = 37.05801536529131, Longitude = 35.355283717576555, Title = "Öğrenci İşleri Daire Başkanlığı" });
        pinList.Add(new PinModel { Latitude = 37.05684623402919, Longitude = 35.357739055824815, Title = "Yabancı Diller Yüksekokulu" });
        pinList.Add(new PinModel { Latitude = 37.05767356400916, Longitude = 35.35787810315542, Title = "Ziraat Fakültesi Toprak Bilimi ve Bitki Besleme Bölümü Ek Bina" });
        pinList.Add(new PinModel { Latitude = 37.05809254490799, Longitude = 35.35782266826736, Title = "Ziraat Fakültesi Toprak Bilimi ve Bitki Besleme Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.05812493144823, Longitude = 35.358634335833784, Title = "Ziraat Fakültesi Gıda Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.05814746120759, Longitude = 35.359306608308884, Title = "Ziraat Fakültesi Bitki Koruma Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.058944500439246, Longitude = 35.357839511311674, Title = "Ziraat Fakültesi Tarım Makinaları ve Teknolojileri Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.05897348753745, Longitude = 35.358526034244825, Title = "Ziraat Fakültesi Tarımsal Yapılar ve Sulama Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.0590285629947, Longitude = 35.35877303722444, Title = "Ziraat Fakültesi Tarım Ekonomisi Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.0590053733362, Longitude = 35.359281572738844, Title = "Ziraat Fakültesi Zootekni Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.05969236404528, Longitude = 35.35871491888556, Title = "Ziraat Fakültesi Tarla Bitkileri Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.06009238107937, Longitude = 35.358177324207745, Title = "Ziraat Fakültesi Bahçe Bitkileri Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.05968946536345, Longitude = 35.35907089373978, Title = "Akif Kansu Toplantı Salonu" });
        pinList.Add(new PinModel { Latitude = 37.060479110504296, Longitude = 35.357763268061696, Title = "Ziraat Fakültesi Dekanlığı" });
        pinList.Add(new PinModel { Latitude = 37.06182931680909, Longitude = 35.356628636020986, Title = "Mithat Özsan Amfisi" });
        pinList.Add(new PinModel { Latitude = 37.060995773508104, Longitude = 35.35466378850921, Title = "R1 Derslikleri" });
        pinList.Add(new PinModel { Latitude = 37.06104984702895, Longitude = 35.35556236895162, Title = "R2 Derslikleri" });
        pinList.Add(new PinModel { Latitude = 37.06060875127589, Longitude = 35.35643074294266, Title = "Kuzey Çarşı" });
        pinList.Add(new PinModel { Latitude = 37.05880700042897, Longitude = 35.3543726683097, Title = "Merkezi Kafeterya Akademik Personel Yemek Salonları" });
        pinList.Add(new PinModel { Latitude = 37.05922956891311, Longitude = 35.3546703468734, Title = "Merkezi Kafeterya Öğrenci Yemek Salonları" });
        pinList.Add(new PinModel { Latitude = 37.0602322979801, Longitude = 35.35500746920046, Title = "Merkez Kütüphane" });
        pinList.Add(new PinModel { Latitude = 37.060054794306936, Longitude = 35.35530770623433, Title = "Fen Bilimleri Enstitüsü (Kütüphane Binası 1.Kat)" });
        pinList.Add(new PinModel { Latitude = 37.059863758496675, Longitude = 35.35476408768042, Title = "Bilgi İşlem Daire Başkanlığı Ağ Hizmetleri ve Kullanıcı Destek Birimi" });
        pinList.Add(new PinModel { Latitude = 37.06001181128925, Longitude = 35.35466434115754, Title = "Basımevi" });
        pinList.Add(new PinModel { Latitude = 37.060190628913006, Longitude = 35.3534259171576, Title = "Su Ürünleri Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.060249128596084, Longitude = 35.35528174298815, Title = "Enformatik Bölümü (Kütüphane Binası 3.kat)" });
        pinList.Add(new PinModel { Latitude = 37.056695093144775, Longitude = 35.34999086124393, Title = "İktisadi ve İdari Bilimler Fakültesi Dekanlık" });
        pinList.Add(new PinModel { Latitude = 37.05958303352873, Longitude = 35.352509040196345, Title = "İktisadi ve İdari Bilimler Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.058435309480444, Longitude = 35.35196747530882, Title = "İktisadi ve İdari Bilimler Fakültesi Derslikler" });
        pinList.Add(new PinModel { Latitude = 37.060087657758935, Longitude = 35.35254065043294, Title = "Fen Edebiyat Fakültesi Matematik, İstatistik Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.06135862575751, Longitude = 35.352066457159104, Title = "Mühendislik Fakültesi Çevre-Endüstri Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.06130482662227, Longitude = 35.351554572191105, Title = "Mühendislik Fakültesi Elektrik Elektronik Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.061105125019566, Longitude = 35.350806514799984, Title = "Mühendislik Fakültesi Bilgisayar Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.06099731204693, Longitude = 35.35069590824529, Title = "Mühendislik Fakültesi Toplantı Salonu" });
        pinList.Add(new PinModel { Latitude = 37.060913406876054, Longitude = 35.35284239306006, Title = "Mühendislik Fakültesi Tekstil Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.06178086153, Longitude = 35.35397137088843, Title = "Mühendislik Fakültesi Dekanlığı" });
        pinList.Add(new PinModel { Latitude = 37.06147421351342, Longitude = 35.35477872322296, Title = "Mühendislik Fakültesi Amfileri" });
        pinList.Add(new PinModel { Latitude = 37.06147028804978, Longitude = 35.35520423345529, Title = " II. Grup Amfiler (Amfi 4-5)" });
        pinList.Add(new PinModel { Latitude = 37.06202618164896, Longitude = 35.356283443389344, Title = "I. Grup Amfiler" });
        pinList.Add(new PinModel { Latitude = 37.06245081316175, Longitude = 35.3533181320562, Title = "Mühendislik Fakültesi Atölyeleri" });
        pinList.Add(new PinModel { Latitude = 37.06272627851535, Longitude = 35.35637790726201, Title = "Fen Edebiyat Fakültesi Dekanlığı" });
        pinList.Add(new PinModel { Latitude = 37.05730581830147, Longitude = 35.35463845765388, Title = "Rektörlük" });
        pinList.Add(new PinModel { Latitude = 37.05696680243532, Longitude = 35.35909412754611, Title = "Amfi Tiyatro" });
        pinList.Add(new PinModel { Latitude = 37.05763237549062, Longitude = 35.35733660309162, Title = "Dış İlişkiler Ofisi" });
        pinList.Add(new PinModel { Latitude = 37.05775480414784, Longitude = 35.359346919082704, Title = "Ziraat Fakültesi Bitki Koruma Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.05813349830181, Longitude = 35.357249716771705, Title = "Merkez Santral" });
        pinList.Add(new PinModel { Latitude = 37.05799806373064, Longitude = 35.357249716771705, Title = "PTT" });
        pinList.Add(new PinModel { Latitude = 37.05783467741087, Longitude = 35.36015553814429, Title = "Afife Jale Tiyatro Salonu" });
        pinList.Add(new PinModel { Latitude = 37.058514458913166, Longitude = 35.36029807206754, Title = "Ziraat Fakültesi Satış Kantini" });
        pinList.Add(new PinModel { Latitude = 37.062071488153876, Longitude = 35.35458291424486, Title = "Eğitim Fakültesi Dekanlığı" });
        pinList.Add(new PinModel { Latitude = 37.06273804692331, Longitude = 35.35584716773454, Title = "Fen Edebiyat Fakültesi (Fizik, Kimya, Biyoloji Bölümleri)" });
        pinList.Add(new PinModel { Latitude = 37.056445084501455, Longitude = 35.35729041955432, Title = "Çukurova Üniversitesi TÖMER" });
        pinList.Add(new PinModel { Latitude = 37.05439771636391, Longitude = 35.35714375334218, Title = "Özdemir Sabancı Kapalı Yüzme Havuzu" });
        pinList.Add(new PinModel { Latitude = 37.05385637767694, Longitude = 35.35575069072177, Title = "Sakıp Sabancı Spor ve Sergi Sarayı" });
        pinList.Add(new PinModel { Latitude = 37.053449948919514, Longitude = 35.35787588708052, Title = "Lütfullah Aksungur Spor Salonu" });
        pinList.Add(new PinModel { Latitude = 37.05263922070107, Longitude = 35.355194784758005, Title = "Spor Bilimleri Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.0527887360308, Longitude = 35.356880875611594, Title = "Jimnastik Salonu" });
        pinList.Add(new PinModel { Latitude = 37.05204519745192, Longitude = 35.35652644210744, Title = "Atletizm Pisti ve Stadı" });
        pinList.Add(new PinModel { Latitude = 37.05277661317384, Longitude = 35.35749353927179, Title = "Sağlıklı Yaşam ve Spor Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.061909735121915, Longitude = 35.36735688200585, Title = "Çukurova Üniversitesi Şoförler Odası" });
        pinList.Add(new PinModel { Latitude = 37.06196605669237, Longitude = 35.3666652002051, Title = "Çukurova Üniversitesi Bakım İşletme Müdürlüğü" });
        pinList.Add(new PinModel { Latitude = 37.057724002992536, Longitude = 35.365805027828124, Title = "Deneysel Cerrahi Araştırma ve Uygulama Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.054802985172095, Longitude = 35.36539232080737, Title = "Çukurova Üniversitesi Halil Avcı Duyma Engelliler Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.05866541322881, Longitude = 35.36207566771223, Title = "Çukurova Üniversitesi Devlet Konservatuvarı" });
        pinList.Add(new PinModel { Latitude = 37.05959563119648, Longitude = 35.36176611226948, Title = "Çukurova Üniversitesi Mediko Sosyal Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.05922119707496, Longitude = 35.36107286627222, Title = "Çukurova Üniversitesi Isı Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.05475053311683, Longitude = 35.363120310397406, Title = "Çukurova Üniversitesi Hipokrat Konferans Salonu" });
        pinList.Add(new PinModel { Latitude = 37.053860540049, Longitude = 35.366775625757114, Title = "Çukurova Üniversitesi Tropikal Hastalıklar Araştırma ve Uygulama Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.05344982019046, Longitude = 35.364625547643335, Title = "Abdi Sütcü Sağlık Hizmetleri Meslek Yüksekokulu" });
        pinList.Add(new PinModel { Latitude = 37.05297723919148, Longitude = 35.36691150078341, Title = "Diş Hekimliği Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.0518985461271, Longitude = 35.36770199430421, Title = "Ziraat Fakültesi Çiftlik Lojmanları" });
        pinList.Add(new PinModel { Latitude = 37.05101314119589, Longitude = 35.36767793997585, Title = "Biyoteknoloji Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.048701988750906, Longitude = 35.36890214707087, Title = "İletişim Fakültesi Stüdyoları" });
        pinList.Add(new PinModel { Latitude = 37.04964653410397, Longitude = 35.36839743417022, Title = "Çukurova Üniversitesi Merkezi Araştırma Laboratuvarı" });
        pinList.Add(new PinModel { Latitude = 37.04785466600578, Longitude = 35.36807546214739, Title = "İletişim Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.041626352643924, Longitude = 35.36051875225532, Title = "Çukurova TEKNOKENT" });
        pinList.Add(new PinModel { Latitude = 37.040391860746524, Longitude = 35.361874960221066, Title = "Mühendislik Fakültesi Otomotiv Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.04216433694409, Longitude = 35.36529378530724, Title = "Hukuk Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.047752947195136, Longitude = 35.364888650489576, Title = "Çukurova Üniversitesi Kongre Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.05527858181606, Longitude = 35.36325008110303, Title = "Çukurova Üniversitesi Balcalı Hastanesi" });
        pinList.Add(new PinModel { Latitude = 37.05663187390053, Longitude = 35.36182821354994, Title = "Çukurova Üniversitesi Balcalı Hastanesi ACİL" });
        pinList.Add(new PinModel { Latitude = 37.055266562044615, Longitude = 35.35856094385023, Title = "Çukurova Üniversitesi Güvenlik Birimi" });
        pinList.Add(new PinModel { Latitude = 37.043640991832646, Longitude = 35.356173151388404, Title = "Çukurova Üniversitesi Anaokulu" });
        pinList.Add(new PinModel { Latitude = 37.04728985088029, Longitude = 35.34337855851899, Title = "Çukurova Üniversitesi Kayıkhane" });
        pinList.Add(new PinModel { Latitude = 37.04712807444452, Longitude = 35.344079715343725, Title = "Çukurova Üniversitesi Su Sporları ve Yelken Kulübü" });
        pinList.Add(new PinModel { Latitude = 37.04846140031073, Longitude = 35.343141266801105, Title = "Çukurova Üniversitesi 1 Nolu Konukevi" });
        pinList.Add(new PinModel { Latitude = 37.045734886388466, Longitude = 35.34869306559226, Title = "Çukurova Üniversitesi Sosyal Tesisler Lojmanları" });
        pinList.Add(new PinModel { Latitude = 37.050148398420006, Longitude = 35.34912471895418, Title = "Çukurova Üniversitesi Ali Nihat Gökyiğit Botanik Bahçesi" });
        pinList.Add(new PinModel { Latitude = 37.05682276497286, Longitude = 35.35147674548143, Title = "Çukurova Üniversitesi III Nolu Konukevi" });
        pinList.Add(new PinModel { Latitude = 37.05271047444822, Longitude = 35.353518362032524, Title = "Çukurova Üniversitesi Subtropik Meyveler Araştırma ve Uygulama Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.056335313270026, Longitude = 35.354083317702546, Title = "Çukurova Üniversitesi Park ve Bahçeler Şube Müdürlüğü" });
        pinList.Add(new PinModel { Latitude = 37.05010705237496, Longitude = 35.36489707870118, Title = "Sosyal Bilimler Enstitüsü" });
        pinList.Add(new PinModel { Latitude = 37.04781456767379, Longitude = 35.3643830590885, Title = "ÖSYM Adana E-Sınav Merkezi" });
        pinList.Add(new PinModel { Latitude = 37.05966388800163, Longitude = 35.36196724182357, Title = "Bağımlılık ve Adli Bilimler Enstitüsü" });
        pinList.Add(new PinModel { Latitude = 37.0594246897935, Longitude = 35.36174219456832, Title = "Sağlık Bilimleri Enstitüsü" });
        pinList.Add(new PinModel { Latitude = 37.061057209099424, Longitude = 35.3524344848166, Title = "Ç.Ü. Ziraat Fakültesi Satış Kantini" });
        pinList.Add(new PinModel { Latitude = 37.06025815552046, Longitude = 35.35520079037986, Title = "Uzaktan Eğitim Araştırma ve Uygulama Merkezi (Kütüphane Binası 3 . Kat)" });
        pinList.Add(new PinModel { Latitude = 37.059228304634146, Longitude = 35.363885919471954, Title = "Tıp Fakültesi Dekanlığı" });
        pinList.Add(new PinModel { Latitude = 37.05921469834623, Longitude = 35.363527865123835, Title = "Tıp Fakültesi Amfileri" });
        pinList.Add(new PinModel { Latitude = 37.04329917449897, Longitude = 35.366439292583024, Title = "Eczacılık Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.05973538956289, Longitude = 35.36325163033247, Title = "Mühendislik Fakültesi Biyomedikal Mühendisliği Bölümü" });
        pinList.Add(new PinModel { Latitude = 37.061467440373455, Longitude = 35.36623646809867, Title = "İlahiyat Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.05023422132047, Longitude = 35.365540912730246, Title = "Güzel Sanatlar Fakültesi" });
        pinList.Add(new PinModel { Latitude = 37.06009476548908, Longitude = 35.36730412482004, Title = "Sağlık Bilimleri Fakültesi" });




        ListView pinListView = new ListView();
        pinListView.ItemsSource = pinList;
        pinListView.ItemTemplate = new DataTemplate(() =>
        {
            Label titleLabel = new Label();
            titleLabel.SetBinding(Label.TextProperty, "Title");

            return new ViewCell { View = new StackLayout { Children = { titleLabel } } };
        });
        pinListView.ItemSelected += PinListView_ItemSelected;

        SearchBar searchBar = new SearchBar();
        searchBar.TextChanged += (sender, e) =>
        {
            string searchText = e.NewTextValue;
            pinListView.ItemsSource = pinList.Where(pin => pin.Title.Contains(searchText));
        };

        Content = new StackLayout
        {
            Children = {  searchBar, pinListView } 
        };
    }
    private void PinListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is PinModel selectedPin)
        {
            var map = new Maui.GoogleMaps.Map();
            map.Pins.Add(new Pin
            {
                Position = new Position(selectedPin.Latitude, selectedPin.Longitude),
                Label = selectedPin.Title
            });

            
            var center = new Position(selectedPin.Latitude, selectedPin.Longitude);
            var span = Distance.FromKilometers(1); 
            map.MoveToRegion(MapSpan.FromCenterAndRadius(center, span));

           
            var mapPage = new ContentPage { Content = map };
            Navigation.PushAsync(mapPage);
        }
    }
    }

public class PinModel
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Title { get; set; }

}
