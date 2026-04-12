# 📡 Documentação de Endpoints - Locadora de Veículos

## 🔗 Base URL
`https://localhost:7050/api`

---

## 🚗 Veículos

### GET /api/Veiculos
**Descrição:** Lista todos os veículos cadastrados.  
**Parâmetros:** Nenhum  
**Respostas:**
- `200 OK` — Lista de veículos

### GET /api/Veiculos/{id}
**Descrição:** Busca um veículo pelo ID.  
**Parâmetros:**
- `id` (int) — Identificador do veículo  
**Respostas:**
- `200 OK` — Veículo encontrado
- `404 Not Found` — Veículo não encontrado

### GET /api/Veiculos/fabricante/{idFabricante}
**Descrição:** Lista veículos de um fabricante específico.  
**Parâmetros:**
- `idFabricante` (int) — Identificador do fabricante  
**Respostas:**
- `200 OK` — Lista de veículos do fabricante

### GET /api/Veiculos/categoria/{idCategoria}
**Descrição:** Lista veículos de uma categoria específica.  
**Parâmetros:**
- `idCategoria` (int) — Identificador da categoria  
**Respostas:**
- `200 OK` — Lista de veículos da categoria

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
- `204 No Content` — Atualizado com sucesso
- `400 Bad Request` — Dados inválidos
- `404 Not Found` — Veículo não encontrado

### DELETE /api/Veiculos/{id}
**Descrição:** Remove um veículo pelo ID.  
**Parâmetros:**
- `id` (int) — Identificador do veículo  
**Respostas:**
- `204 No Content` — Removido com sucesso
- `404 Not Found` — Veículo não encontrado

---

## 🏭 Fabricantes

### GET /api/Fabricantes
**Descrição:** Lista todos os fabricantes cadastrados.  
**Parâmetros:** Nenhum  
**Respostas:**
- `200 OK` — Lista de fabricantes

### GET /api/Fabricantes/{id}
**Descrição:** Busca um fabricante pelo ID.  
**Parâmetros:**
- `id` (int) — Identificador do fabricante  
**Respostas:**
- `200 OK` — Fabricante encontrado
- `404 Not Found` — Fabricante não encontrado

### POST /api/Fabricantes
**Descrição:** Cadastra um novo fabricante.  
**Body de exemplo:**
```json
{
  "nome": "Toyota",
  "paisOrigem": "Japão"
}
