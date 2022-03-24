# departamento_policial

#Test em C# para Cidade alta

### Projeto utilizei modelo de CQRS para o controle de entrada e saida no sistema.

são três tabelas usadas no projeto 
-> User 
-> Status
-> CriminalCode

### Foi utilizado a ORM EF core Sqlite para fazer as migrations e utilizar o banco de dados relacional.

Para as consultas do criminalCode seria necessario o User (Usuario) estar cadastrado no banco de dados <br/> 
e também vai ser necessario a ID do CriminalCode para garantir que o usuario está cadastrado no controller <br/> 
do criminalCode vai passar pela autentificação Bearer Token do User a authentificação é feita antes dos processos <br/> 
de qualquer tipo de consulta (Deleted, list, Update, Create)

No Response então vai trazer toda informação necessaria para aquela determinada requisição

Deleted 

-> 
{ <br/>
"Message": "Criminal Code deleted is successfully", <br/>
  "Criminal code": <br/>
  { <br/>
  "id": "id", <br/>
  "name": "name" <br/>
  } <br/>
} <br/>

Updated <br/>

{ <br/>
"Message": "Criminal Code has updated", <br/>
  "Criminal Code": <br/>
  { <br/>
  "id": "id", <br/>
  "name": "Jose Do laudo", <br/>
  "Description": "Lei  para ...", <br/>
  "Penalty": 100, <br/>
  "StatusId": 20, <br/>
  "UpdatedUserId": UserAutentificado <br/>
  "Created_at": dataTime utc, <br/>
  "Updated_at": DataTime NOW() <br/>
  } <br/>
}<br/>

