# 🧾 Sistema de Estoque de Produtos - Windows Forms (.NET Framework)

Projeto desenvolvido como parte da disciplina **Lógica de Programação e Algoritmos II**, ministrada pelo Prof. **Gabriel F. Cyrino**, no curso de **Ciência da Computação**.

Este sistema tem como objetivo **gerenciar o cadastro de produtos**, exibindo-os em uma lista e permitindo o **armazenamento em arquivo CSV ou TXT**, com tratamento básico de exceções.

---

## 🧠 Objetivos da Atividade

Criar um aplicativo **Windows Forms em C#** (.NET Framework 4.8) que:
- Cadastre produtos com os campos obrigatórios;
- Liste todos os produtos cadastrados em um `ListView`;
- Salve os dados em arquivo (`.csv` ou `.txt`);
- Realize validações e trate exceções com `try/catch`.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** Windows Forms (.NET Framework 4.8)
- **Controles Utilizados:**  
  `Form`, `ListView`, `TextBox`, `Button`, `MessageBox`
- **Persistência:** Arquivo CSV (separado por `;`) ou TXT

---

## 🧩 Estrutura do Projeto

O sistema foi organizado em **três classes principais**, seguindo boas práticas de encapsulamento e separação de responsabilidades:

```
├── Produto.cs       # Representa a entidade Produto
├── Estoque.cs       # Gerencia a lista de produtos
└── MainForm.cs      # Interface gráfica (Windows Form)
```

---

## 🧱 Descrição das Classes

### 🏷️ Produto.cs
Representa um produto do estoque.

**Atributos:**
- Código (`string`)
- Descrição (`string`)
- Fornecedor (`string`)
- Preço (`float`)
- Quantidade (`int`)

**Métodos principais:**
- Construtor parametrizado `Produto(string codigo, string descricao, string fornecedor, float preco, int quantidade)`
- Propriedades com encapsulamento (`get`/`set`)

---

### 📦 Estoque.cs
Gerencia a coleção de produtos e suas operações.

**Atributo principal:**
- `List<Produto> itens`

**Métodos:**
- `AdicionarProduto(Produto p)` → Adiciona um produto validando duplicidade.  
- *(Opcionais)*: `RemoverProdutoPorCodigo`, `BuscarProdutoPorDescricao`, `AtualizarProduto`, etc.

---

### 🪟 MainForm.cs
Interface principal do sistema (Windows Form).

**Componentes principais:**
- Campos de entrada: Código, Descrição, Fornecedor, Preço, Quantidade
- Botões: `Novo`, `Salvar`
- `ListView` com as colunas: Código, Descrição, Fornecedor, Preço, Quantidade

**Métodos:**
- `btnNovo_Click()` → Limpa os campos para novo cadastro  
- `btnSalvar_Click()` → Cadastra o produto e salva no arquivo  
- `SalvarCsv()` → Persiste os dados em arquivo CSV  
- *(Opcionais)*: `CarregarCsv()`, `btnRemover_Click()`, `btnEditar_Click()`

---

## 💾 Persistência de Dados

O sistema salva os produtos em um arquivo `.csv` no formato:

```
Código;Descrição;Fornecedor;Preço;Quantidade
```

Cada novo produto é adicionado e o arquivo é sobrescrito, mantendo os dados atualizados.

**Exemplo de linha no arquivo:**
```
P001;Mouse Gamer RGB;Logitech;150.90;20
```

---

## ⚙️ Tratamento de Exceções

Todos os pontos críticos do sistema estão protegidos com `try/catch`:

- Conversão de campos numéricos (`float` e `int`)
- Validação de campos obrigatórios
- Operações de leitura/escrita no arquivo
- Mensagens de erro amigáveis via `MessageBox`

---

## 🧪 Funcionalidades Implementadas

✅ Cadastro de produtos  
✅ Exibição na lista (`ListView`)  
✅ Validação de duplicidade de código  
✅ Salvamento dos dados em arquivo `.csv`  
✅ Tratamento de exceções básicas  
⚙️ *(opcional)* Carregamento automático do arquivo ao iniciar

---

## 📸 Exemplo de Interface

A interface foi construída de forma simples e funcional, com áreas distintas para **cadastro** e **listagem** dos produtos.

  
```bash
![Interface do Sistema](..png)
```

---

## 🧑‍💻 Como Executar o Projeto

1. Abra o projeto no **Visual Studio 2022** (ou superior);
2. Certifique-se de que o projeto está configurado para o **.NET Framework 4.8**;
3. Compile e execute (`Ctrl + F5`);
4. Utilize os botões para cadastrar e salvar produtos.

---

## 🧾 Autor

**Nome:** *Kauã Lourenço Borges*  
**Disciplina:** Lógica de Programação e Algoritmos II  
**Professor:** Gabriel F. Cyrino  
**Instituição:** Ciência da Computação - [Unitri]  
**Ano:** 2025  

---

## 📚 Licença

Este projeto foi desenvolvido para fins educacionais.  
Você é livre para reutilizá-lo ou adaptá-lo conforme necessário.

---

⭐ Se este projeto te ajudou, considere deixar uma estrela no repositório!
