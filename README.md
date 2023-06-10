# Login App
(.Net, C#, SqlServer, Database, EntityFrameWork)

### Proje kurulum
1- ilgili dosyalar içerisinde "loginRegister.bak" dosyası yani veritabanı yedek dosyası yüklenir.
</br>
2-app.config dosyası içerisinden "data source" alanı aratılır ve ilgili baglanti yerine local makinede ki adres eklenir
</br>
 data source=DESKTOP-74DVE87\SQLEXPRESS; 


### Kullanıcı Oluşturma Sayfası
bu sayfada ilgili öğrencinin veya kullanıcının bilgileri girildikten sonra oluştur butonuna tıklandığında veritabanına yeni veriyi kaydetme işlemi gerçekleşir.

<img src="yeniKullaniciSayfasi.png" center></img>
</br>

### kullanıcı giriş sayfası
bu sayfada ilgili kişinin kaydı yapıldıktan sonra sorgu ile textboxtan alınan veriler veritabanında ki ilgili kişinin numarası ve şifresi ile karşılaştırılır. veriler doğru ise uygulama sistemine giriş yapar. yanlış ise kullanıcıya messagebox gelir

<img src="girisSayfasi.png"></img>
</br>

### Uygulama Sayfası
giriş yapan kullanıcıların bilgilerini veritabanından çeker ve onunla ilgili bilgileri gösterir.
<img src="anaSayfa.png"></img>
</br>

