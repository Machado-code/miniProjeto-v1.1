# miniProjeto-v1.1
API/WEB APP .NET Core 3.1 / Entity Framework / Code-first / Swagger

<!---Esses são exemplos. Veja https://shields.io para outras pessoas ou para personalizar este conjunto de escudos. Você pode querer incluir dependências, status do projeto e informações de licença aqui--->

![GitHub repo size](https://img.shields.io/github/repo-size/Machado-code/miniProjeto?style=for-the-badge)
![Version](https://img.shields.io/docker/v/Machado-code/weberpacx?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/Machado-code/miniProjeto?style=for-the-badge)
![GitHub forks](https://img.shields.io/github/forks/Machado-code/miniProjeto?style=for-the-badge)
![Bitbucket open issues](https://img.shields.io/bitbucket/issues/Machado-code/miniProjeto?style=for-the-badge)
![Bitbucket open pull requests](https://img.shields.io/bitbucket/pr-raw/Machado-code/miniProjeto?style=for-the-badge)
![GitHub contributors](https://img.shields.io/github/contributors/Machado-code/miniProjeto?style=for-the-badge)
<img src="exemplo-image.png" alt="exemplo imagem">

> Sistema WEB API para cadastro de Produtos e Categorias

## :technologist: Técnologia / Padões Utilizado
- MVC (Model-View-Controller) utilizado para separar a arquitetura do software para facilitar a compreensão e a manutenção.
- C#
- WEB Api (Interface de programação de aplicação servidor/navegador)
- .Net Core v3.1 (Framework livre e de codigo aberto)
- EntityFramwork
- EntityFramwork Code-First (Gera o foco no desenvolvimento da aplicação em primeiro plano, ao inves de focar na construção do banco de dados)
- Teste com Git Actions
- Swagger


## 💻 Pré-requisitos

Antes de começar, verifique se você atendeu aos seguintes requisitos:
<!---Estes são apenas requisitos de exemplo. Adicionar, duplicar ou remover conforme necessário--->
* Visual Studio 2019 Instalado
* Você tem uma máquina `<Windows / Linux / Mac>`.
* MYSQL Instalado em sua Maquina (Usuario: root e Senha: admin)

## 🚀 Configurando Base de Dados MYSQL

Para criar a database/tabelas utilizada no projeto, siga estas etapas:

- Ter o MYSQL Instalado em seu computador
- Abrir miniProjeto.sln no Visual Studio 2019
- Compilar Projeto (Menu Compilação > Compilar Solução ou Clique com botão direito(mouse) na solução miniProjeto > Compilar)
- Executar comando Migration ( Ferramentas > Gerenciador de Pacotes NuGet > Console do Gerenciador de Pacotes )
- executar o comando **update-database**


## ☕ Usando o mineProjeto

Para usar o miniProjeto, siga estas etapas:

Com o miniProjeto aberto no Visual Studio 2019:
- Clicar em: **Depurar > Iniciar Depuração**
<br/>Ou
- Clicar na tecla **F5** com o projeto/solução já aberto.
- Abrirá uma pagina WEB de seu navegador padrão com a execução do miniProjeto para cadastro de produtos.


## 📫 Contribuindo
<!---Se o seu README for longo ou se você tiver algum processo ou etapas específicas que deseja que os contribuidores sigam, considere a criação de um arquivo CONTRIBUTING.md separado--->
Para contribuir, siga estas etapas:

1. Bifurque este repositório.
2. Crie um branch: `git checkout -b <nome_branch>`.
3. Faça suas alterações e confirme-as: `git commit -m '<mensagem_commit>'`
4. Envie para o branch original: `git push origin <nome_do_projeto> / <local>`
5. Crie a solicitação de pull.

Como alternativa, consulte a documentação do GitHub em [como criar uma solicitação pull](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/creating-a-pull-request).

## 🤝 Colaboradores

Agradecemos às seguintes pessoas que contribuíram para este projeto:

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/matheus-code" target="_blank">
        <img src="https://chingizpro.github.io/portfolio/img/person.png" width="100px;"/><br>
        <sub>
          <b>Matheus Machado</b>
        </sub>
      </a>
    </td>
  </tr>
</table>



## 📝 Licença

Esse projeto está sob licença. Veja o arquivo [LICENÇA](LICENSE.md) para mais detalhes.
