# 🚀 Azure AI Translator API

> **Enterprise‑grade REST API for text translation using Microsoft Azure Cognitive Services**
> Built with **ASP.NET Core**, focused on **security, clean architecture, and didactic clarity** for **Brazil 🇧🇷 and USA 🇺🇸 developers**.

---

## 🌍 Overview

This project exposes a **RESTful API** that integrates with **Azure AI Translator (Text Translation)**, allowing applications to translate text between multiple languages in a **secure, scalable, and production‑ready** way.

It was designed with **senior‑level engineering standards**, while maintaining **clear didactics** so students, junior devs, and professionals can easily understand and extend the solution.

---

## 🧠 Key Concepts Demonstrated

* REST API design with **ASP.NET Core**
* Integration with **Azure Cognitive Services**
* Secure handling of **secrets and credentials**
* Clean separation of concerns (Controller / Service / Model)
* HTTP client best practices
* Professional Git & GitHub workflow

---

## 🏗️ Architecture

```text
Client
  │
  ▼
Controller (TranslateController)
  │
  ▼
Service Layer (TranslatorService)
  │
  ▼
Azure AI Translator API
```

### Layers

* **Controllers**
  Responsible only for HTTP concerns (request/response).

* **Services**
  Encapsulate business logic and external API communication.

* **Models**
  Strongly‑typed request/response objects.

This structure follows **Clean Architecture principles** without unnecessary complexity.

---

## ⚙️ Technologies & Tools

* **.NET 7 / ASP.NET Core Web API**
* **Azure AI Translator (Cognitive Services)**
* **C#**
* **HTTPClient Factory**
* **Git & GitHub**

---

## 🔐 Security Best Practices (Very Important)

✔ **No secrets are stored in the repository**
✔ API keys are injected via **User Secrets** or **Environment Variables**
✔ Repository is compliant with **GitHub Push Protection**

### Recommended Configuration (Local Development)

```bash
dotnet user-secrets init

dotnet user-secrets set "Translator:Key" "YOUR_AZURE_KEY"
dotnet user-secrets set "Translator:Region" "brazilsouth"
```

Example `appsettings.json` (safe to commit):

```json
{
  "Translator": {
    "Key": "",
    "Endpoint": "https://api.cognitive.microsofttranslator.com",
    "Region": "brazilsouth"
  }
}
```

---

## 📡 API Endpoint

### 🔁 Translate Text

**POST** `/api/translate`

#### Request Body

```json
{
  "text": "Hello world",
  "from": "en",
  "to": "pt"
}
```

#### Response

```json
{
  "translatedText": "Olá mundo"
}
```

---

## ▶️ How to Run

```bash
dotnet restore
dotnet build
dotnet run
```

The API will be available at:

```text
https://localhost:5001
```

---

## 🧪 Testing

You can test the API using:

* `AzureAITranslator.http`
* Postman
* Insomnia
* curl

Example using curl:

```bash
curl -X POST https://localhost:5001/api/translate \
  -H "Content-Type: application/json" \
  -d '{"text":"Hello","from":"en","to":"pt"}'
```

---

## 🎓 Educational Purpose

This project is actively used in **Technical Education (Brazil – SENAI)** to demonstrate:

* Real‑world cloud API integration
* Secure software development
* Professional backend architecture
* Industry‑ready coding standards

It bridges the gap between **academic learning** and **market expectations**.

---

## 🌎 For Brazilian & International Developers

🇧🇷 **Português**
Projeto pensado para ensinar boas práticas reais de mercado, indo além de exemplos simplificados.

🇺🇸 **English**
This repository reflects real‑world backend engineering standards used in production environments.

---

## 📌 Future Improvements

* Authentication & Authorization
* Logging & Observability
* CI/CD with GitHub Actions
* Docker support
* Rate limiting

---

## 👨‍💻 Author

**Renan Rodrigues Borges Café**
IT Manager | Software Developer | Technical Instructor
Azure AI‑900 | Cloud & Security Enthusiast

🔗 GitHub: [https://github.com/041067](https://github.com/041067)

---

> **"Code is easy. Engineering is responsibility."**
