# Guia de Criação de API em C# usando ASP.NET Core
Este guia fornece um passo a passo para criar uma API em C# utilizando o framework ASP.NET Core. Siga as instruções abaixo para começar.

# Pré-requisitos
Certifique-se de ter os seguintes itens instalados em sua máquina:

# Visual Studio (ou Visual Studio Code)
.NET SDK
Passos
# 1. Criar um novo projeto
Abra o terminal ou o prompt de comando e execute o seguinte comando para criar um novo projeto ASP.NET Core:
<br>
<br>

npm run dev
 ou
yarn dev
# ou
pnpm dev
# ou
bun dev

Abra http://localhost:3000 em seu navegador para visualizar o resultado.

Você pode iniciar a edição da página modificando o arquivo pages/index.js. A página será atualizada automaticamente conforme você edita o arquivo.

Rotas de API
Rotas de API podem ser acessadas em http://localhost:3000/api/hello. O endpoint correspondente pode ser editado no arquivo pages/api/hello.js.

O diretório pages/api é mapeado para /api/*. Os arquivos neste diretório são tratados como rotas de API, em vez de páginas React.

Fonte Personalizada
Este projeto utiliza next/font para otimizar e carregar automaticamente a fonte Inter, uma fonte personalizada do Google.

Saiba Mais
Para aprender mais sobre o Next.js, confira os seguintes recursos:

Documentação do Next.js - aprenda sobre os recursos e a API do Next.js.
Learn Next.js - um tutorial interativo do Next.js.
Repositório do Next.js no GitHub - seu feedback e contribuições são bem-vindos!
Implantação no Vercel
A maneira mais fácil de implantar seu aplicativo Next.js é usar a plataforma Vercel, dos criadores do Next.js.

Confira nossa documentação de implantação do Next.js para mais detalhes.
<br>
# Fim 
<hr>

<h1> Configuração do SQL Server</h1>
Este guia fornece instruções passo a passo sobre como configurar o SQL Server para seu projeto.

# Instalação do SQL Server
Download do SQL Server:
Faça o download da versão desejada do SQL Server no site oficial da Microsoft.

# Instalação:
Siga as instruções de instalação fornecidas pelo assistente de instalação do SQL Server. Certifique-se de selecionar os componentes necessários para sua aplicação, como o SQL Server Database Engine.

# Configuração da Instância:
Durante a instalação, configure a instância do SQL Server de acordo com suas necessidades. Lembre-se das informações da instância, pois serão necessárias posteriormente.

# Configuração de Autenticação
Modo de Autenticação:
Durante a instalação, escolha o modo de autenticação desejado. Você pode optar por autenticação do Windows ou autenticação do SQL Server.

# Conta do SQL Server:
Se optar pela autenticação do SQL Server, forneça as credenciais necessárias. Certifique-se de lembrar o nome de usuário e a senha, pois serão utilizados na configuração do seu aplicativo.

# Configuração de Acesso Remoto (se necessário)
Se você precisar acessar o SQL Server remotamente, siga estas etapas:

# Configuração de Firewall:
Abra as configurações de firewall no servidor e permita a comunicação nas portas usadas pelo SQL Server (normalmente 1433 para TCP).

# Configuração de Rede:
No SQL Server Configuration Manager, habilite o protocolo TCP/IP para a instância do SQL Server desejada.

# Reinicie o Serviço:
Reinicie o serviço do SQL Server após as alterações.

# Configuração no Seu Projeto
Após a instalação e configuração do SQL Server, ajuste as configurações no seu projeto:

# String de Conexão:
No arquivo de configuração do seu aplicativo (por exemplo, app.config ou web.config), defina a string de conexão com o SQL Server. Inclua o nome do servidor, a instância (se houver), o nome do banco de dados e as credenciais.

# Exemplo de String de Conexão:

Server=myServerName\myInstance;Database=myDatabase;User Id=myUsername;Password=myPassword;

# Teste de Conexão:
Execute seu aplicativo e verifique se a conexão com o SQL Server é estabelecida corretamente.

Com estas configurações, seu projeto deverá estar conectado ao SQL Server. Certifique-se de seguir as melhores práticas de segurança ao configurar credenciais e limitar o acesso conforme necessário.





