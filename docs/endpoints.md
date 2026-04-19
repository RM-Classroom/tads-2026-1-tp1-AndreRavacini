# 📡 Documentação de Endpoints - Locadora de Veículos

## 🔗 Base URL
`https://localhost:7050/api`

---

# 🚗 Veículos

### GET /api/Veiculos
**Descrição:** Lista todos os veículos cadastrados.  
**Parâmetros:** Nenhum  

**Respostas:**
- `200 OK` — Lista de veículos

**Exemplo de resposta:**
```json
[
  {
    "idVeiculo": 1,
    "modelo": "Corolla",
    "anoFabricacao": 2023,
    "quilometragemAtual": 15000,
    "placa": "ABC1234",
    "cor": "Prata",
    "valorDiariaBase": 150,
    "status": "Disponivel",
    "idFabricante": 1,
    "idCategoriaVeiculo": 1
  }
]
```

---

### GET /api/Veiculos/{id}
**Descrição:** Busca um veículo pelo ID.  

**Parâmetros:**
- `id` (int) — Identificador do veículo  

**Respostas:**
- `200 OK` — Veículo encontrado
- `404 Not Found` — Veículo não encontrado

---

### GET /api/Veiculos/fabricante/{idFabricante}
**Descrição:** Lista veículos de um fabricante específico.  

**Parâmetros:**
- `idFabricante` (int)

**Respostas:**
- `200 OK` — Lista filtrada

---

### GET /api/Veiculos/categoria/{idCategoria}
**Descrição:** Lista veículos de uma categoria específica.  

**Parâmetros:**
- `idCategoria` (int)

**Respostas:**
- `200 OK` — Lista filtrada

---

### POST /api/Veiculos
**Descrição:** Cadastra um novo veículo.  

**Body de exemplo:**
```json
{
  "modelo": "Corolla",
  "anoFabricacao": 2023,
  "quilometragemAtual": 15000,
  "placa": "ABC1234",
  "cor": "Prata",
  "valorDiariaBase": 150,
  "status": "Disponivel",
  "idFabricante": 1,
  "idCategoriaVeiculo": 1
}
```

**Respostas:**
- `201 Created` — Veículo cadastrado com sucesso
- `400 Bad Request` — Dados inválidos

---

### PUT /api/Veiculos/{id}
**Descrição:** Atualiza um veículo existente.  

**Parâmetros:**
- `id` (int)

**Respostas:**
- `204 No Content` — Atualizado com sucesso
- `400 Bad Request`
- `404 Not Found`

---

### DELETE /api/Veiculos/{id}
**Descrição:** Remove um veículo.  

**Parâmetros:**
- `id` (int)

**Respostas:**
- `204 No Content`
- `404 Not Found`

---

# 🏭 Fabricantes

### GET /api/Fabricantes
**Descrição:** Lista todos os fabricantes.  

**Respostas:**
- `200 OK`

---

### GET /api/Fabricantes/{id}
**Descrição:** Busca fabricante por ID.  

**Parâmetros:**
- `id` (int)

**Respostas:**
- `200 OK`
- `404 Not Found`

---

### POST /api/Fabricantes
**Descrição:** Cadastra um fabricante.  

**Body de exemplo:**
```json
{
  "nome": "Toyota",
  "paisOrigem": "Japão"
}
```

**Respostas:**
- `201 Created`
- `400 Bad Request`

---

### PUT /api/Fabricantes/{id}
**Descrição:** Atualiza fabricante.  

**Respostas:**
- `204 No Content`
- `404 Not Found`

---

### DELETE /api/Fabricantes/{id}
**Descrição:** Remove fabricante.  

**Respostas:**
- `204 No Content`
- `404 Not Found`

---

# 👤 Clientes

### GET /api/Clientes
**Descrição:** Lista todos os clientes.  

**Respostas:**
- `200 OK`

**Exemplo de resposta:**
```json
[
  {
    "idCliente": 1,
    "nome": "João Silva",
    "cpf": "12345678900",
    "email": "joao@email.com",
    "telefone": "11999999999",
    "cnh": "123456789"
  }
]
```

---

### POST /api/Clientes
**Descrição:** Cadastra cliente.  

**Body de exemplo:**
```json
{
  "nome": "João Silva",
  "cpf": "12345678900",
  "email": "joao@email.com",
  "telefone": "11999999999",
  "cnh": "123456789"
}
```

**Respostas:**
- `201 Created`
- `400 Bad Request`

---

### GET /api/Clientes/{id}
**Descrição:** Busca cliente por ID.  

**Respostas:**
- `200 OK`
- `404 Not Found`

---

### PUT /api/Clientes/{id}
**Descrição:** Atualiza cliente.  

**Respostas:**
- `204 No Content`
- `404 Not Found`

---

### DELETE /api/Clientes/{id}
**Descrição:** Remove cliente.  

**Respostas:**
- `204 No Content`
- `404 Not Found`

---

# 📂 Categorias de Veículo

### GET /api/CategoriasVeiculo
**Descrição:** Lista categorias.  

**Respostas:**
- `200 OK`

---

### POST /api/CategoriasVeiculo
**Descrição:** Cadastra categoria.  

**Body de exemplo:**
```json
{
  "nome": "SUV",
  "descricao": "Veículos utilitários esportivos"
}
```

**Respostas:**
- `201 Created`

---

### GET /api/CategoriasVeiculo/{id}
**Descrição:** Busca categoria por ID.  

**Respostas:**
- `200 OK`
- `404 Not Found`

---

### PUT /api/CategoriasVeiculo/{id}
**Descrição:** Atualiza categoria.  

**Respostas:**
- `204 No Content`

---

### DELETE /api/CategoriasVeiculo/{id}
**Descrição:** Remove categoria.  

**Respostas:**
- `204 No Content`

---

# 📄 Aluguéis

### GET /api/Alugueis
**Descrição:** Lista todos os aluguéis.  

**Respostas:**
- `200 OK`

**Observação:** Retorna dados relacionados de cliente e veículo.

---

### POST /api/Alugueis
**Descrição:** Cadastra um aluguel.  

**Body de exemplo:**
```json
{
  "dataRetirada": "2026-04-12T10:00:00",
  "dataPrevistaDevolucao": "2026-04-15T10:00:00",
  "quilometragemInicial": 15000,
  "valorDiaria": 200,
  "valorTotal": 600,
  "status": "Ativo",
  "idCliente": 1,
  "idVeiculo": 1
}
```

**Respostas:**
- `201 Created`
- `400 Bad Request`

---

### GET /api/Alugueis/{id}
**Descrição:** Busca aluguel por ID.  

**Respostas:**
- `200 OK`
- `404 Not Found`

---

### PUT /api/Alugueis/{id}
**Descrição:** Atualiza aluguel.  

**Respostas:**
- `204 No Content`
- `404 Not Found`

---

### DELETE /api/Alugueis/{id}
**Descrição:** Remove aluguel.  

**Respostas:**
- `204 No Content`
- `404 Not Found`

---

# 🔍 Observações Gerais

- Os endpoints seguem o padrão REST
- O Swagger foi utilizado para testes e validação
- Os relacionamentos são retornados automaticamente (Cliente e Veículo dentro de Aluguel)
- Para criação (POST), apenas IDs são enviados nos relacionamentos

---
