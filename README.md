# departamento_policial

#Test em C# para Cidade alta

### Projeto utilizei modelo de CQRS para o controle de entrada e saida no sistema.

são três tabelas usadas no projeto 
-> User 
-> Status
-> CriminalCode

### Foi utilizado a ORM EF core Sqlite para fazer as migrations e utilizar o banco de dados relacional.

Para as consultas do criminalCode seria necessario o User (Usuario) estar cadastrado no banco de dados e a ID do CriminalCode
para garantir que o usuario está cadastrado no controller do criminalCode vai passar pela autentificação Bearer Token do User
a authentificação é feita antes dos processos de qualquer tipo de consulta (Deleted, list, Update, Create)

No Response então vai trazer toda informação necessaria para aquela determinada requisição

Deleted 

-> 
{
"Message": "Criminal Code deleted is successfully",
  "Criminal code": 
  {
  "id": "id",
  "name": "name"
  }
}

Updated

{
"Message": "Criminal Code has updated",
  "Criminal Code": <br/>
  { <br/>
  "id": "id", <br/>
  "name": "Jose Do laudo", <br/>
  "Description": "Lei  para ...",
  "Penalty": 100,
  "StatusId": 20,
  "UpdatedUserId": UserAutentificado
  "Created_at": dataTime utc,
  "Updated_at": DataTime NOW()
  }
}

