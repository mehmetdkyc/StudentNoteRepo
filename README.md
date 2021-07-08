# StudentNoteRepo
ASP.NET MVC Yapısı ve Mysql kullanarak yapılan student note service mimarisidir.
Authentication işleminde veritabanındaki kullanici tablosunda olan admin ve mehmet adlı kullanıcıların rolü üzerine görebileceği sekmeler mevcuttur.
Admin kullanıcısı öğrencilerin notlarını görebilir ama student rolü olan mehmet hesabı göremez, sadece öğrencilerin kimlik bilgilerini görebilir.

Program ilk çalıştığında otomatik olarak /Security/Login response ile giriş sayfasına yönlendiriliyor. Eğer otomatik olarak gitmiyorsa /Security/Login yazarak gidebilirsiniz.

Admin, 12345 (admin)
Mehmet, 12345 (student)
Giriş bilgileri yukarıda mevcuttur.

Admin;

![image](https://user-images.githubusercontent.com/50601213/124919744-3f80eb00-dfff-11eb-9b5a-a766f2b93efd.png)

![image](https://user-images.githubusercontent.com/50601213/124923626-4b6eac00-e003-11eb-92bf-152f93db2d18.png)

![image](https://user-images.githubusercontent.com/50601213/124923651-545f7d80-e003-11eb-8ddb-3f7e515db91b.png)

Student; 

![image](https://user-images.githubusercontent.com/50601213/124923701-63463000-e003-11eb-81cd-e9772e59fbfe.png)
