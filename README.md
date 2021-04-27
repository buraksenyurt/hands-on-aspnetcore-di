# Hands-On Asp.Net Core Dependency Injection

Asp.Net Core tarafında built-in DI mekanizmasının basit ve gösterişsiz bir örnek üstünden incelenmesi amacıyla açtığım alandır. Blogumdaki [şu](https://www.buraksenyurt.com/post/asp-net-core-a-nasil-merhaba-deriz)
yazı için destekleyicidir.

Konuyu daha iyi anlamak için farklı branch'leri kullanmaya karar verdim.

## initial: Projenin için Başlangıç Konumu 

Bu başlangıç branch'i. Kod çalışıyor ama tightly-coupled durumu söz konusu. Oluşturmak için şunlar yapıldı.

```
cd 
dotnet new sln 
dotnet new mvc -o C64Portal
dotnet sln add C64Portal
```

Bağımlılık ihlali GameController içerisinde, GameRepository sınıfının örneklendiği yer.

## constructor-injection: Constructor Injection Uygulanmış Hal