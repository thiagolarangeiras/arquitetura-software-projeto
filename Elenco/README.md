# Rodando

## Após instalar o visual studio

Instalar as feramentas do entity framework localmente
```sh
dotnet tool install --global dotnet-ef
```

Criar o banco de dados para cada projeto
```sh
dotnet ef migrations add v1 --project ./Gestao/Gestao.csproj
dotnet ef migrations add v1 --project ./Custos/Custos.csproj
dotnet ef migrations add v1 --project ./Elenco/Elenco.csproj
```

Criar tabelas e atualizar
```sh
dotnet ef database update --project ./Gestao/Gestao.csproj
dotnet ef database update --project ./Custos/Custos.csproj
dotnet ef database update --project ./Elenco/Elenco.csproj
```