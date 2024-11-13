# Rodando

## Após instalar o visual studio

Instalar as feramentas do entity framework localmente
```sh
dotnet tool install --global dotnet-ef
```

Criar o banco de dados
```sh
dotnet ef migrations add InitialCreate --project ./gestao/Gestao.csproj
```

Criar tabeas e atualizar
```sh
dotnet ef database update --project ./gestao/Gestao.csproj
```