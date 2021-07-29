Link para aplicação: https://crud-funcionarios.loca.lt/ (Meu banco precisa estar aberto para funcionar).
# CrudFuncionarios

Aplicação criada como desafio de um FreeLance.

#Para executar o projeto em sua maquina é necessario clonar o repositorio em sua maquina.
#Abra o Git Bash ou qualquer outro terminal que execute linhas de comando Git.
#gh repo clone AbnerAWR/CrudFuncionarios

#Para fazer a aplicação funcionar é necessario editar o arquivo appsettings.json e modificar a seguinte linha: (SQL Server)
"DefaultConnection": "Data Source="Nome do seu banco aqui";Initial Catalog=CrudFuncionarios;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
#Caso você utilize Usuario e senha, é necessario criar User="" e Password= para que consiga acessar o banco.

--Foi proposto seguinte desafio:

-Criar uma classe Funcionario
-Criar uma classe Departamento
-Criar uma classe Chefia

Dentro do SQL Server foram feito os seguintes relacionamentos:

- Chefia pode conter varios departamentos

- Cada departamento pode conter apenas uma chefia, porém cada departamento pode conter varios funcionarios.

- Funcionario pode possuir apenas um departamento.

Caso queira apenas testar a aplicação com meu banco, me solicite um acesso do banco.
