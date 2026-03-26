# Utilería de API CALL a LLM (Gemini)

Este proyecto es una utilidad funcional diseñada para facilitar la integración de modelos de lenguaje de gran escala (LLM) en aplicaciones de software mediante llamadas a API. Proporciona una interfaz tipo chat para interactuar con la inteligencia artificial de manera eficiente.

## 📋 Requisitos Previos

Para el correcto funcionamiento del proyecto y evitar errores de compatibilidad, es necesario gestionar las siguientes dependencias:

* **Newtonsoft.Json:** Se debe instalar la **versión 13.0.4** a través del gestor de paquetes NuGet.
* **Entorno:** Compatible con .NET y Windows Forms.

## 🚀 Guía de Uso

Siga estos pasos para ejecutar y probar la interfaz de conexión:

### 1. Iniciar el Proyecto
Abra la solución en Visual Studio y haga clic en el botón **"Iniciar"** (Debug) ubicado en la barra de herramientas superior.
  <img width="498" height="133" alt="1" src="https://github.com/user-attachments/assets/b5e25a29-2922-49b6-99bc-a8c7037e5f28" />


### 2. Interfaz de Usuario
Una vez ejecutado, se presentará una ventana titulada **"ChatGeminiIA"**. La interfaz iniciará limpia, mostrando un área de visualización negra y un cuadro de texto en la parte inferior para ingresar los prompts.
<img width="802" height="402" alt="2" src="https://github.com/user-attachments/assets/8d6bc169-1b57-4d33-868b-3f5df05fba9c" />


### 3. Generación de Prompts
* **Enviar mensaje:** Escriba su pregunta en el cuadro de texto y presione el botón **"Enviar"** o la tecla **Enter**.
  <img width="802" height="397" alt="3" src="https://github.com/user-attachments/assets/76f228c6-4535-4440-8f27-75411158e92a" />

* **Respuesta:** La utilidad procesará la solicitud a través de la clase `GeminiService` y mostrará la respuesta del modelo de forma estructurada y legible en la pantalla.
 <img width="800" height="396" alt="4" src="https://github.com/user-attachments/assets/acdecd23-c1e3-4606-99b0-218eee02a0bd" />


---

## 🛠️ Estructura del Código Fuente

El sistema se basa en una arquitectura sencilla para gestionar la comunicación asíncrona:

| Archivo | Descripción |
| :--- | :--- |
| `GeminiService.cs` | Clase principal que gestiona el `ApiKey`, la URL del endpoint y la serialización de objetos JSON para la API]. |
| `Form1.cs` | Controla la lógica de la interfaz, el manejo de eventos del teclado y el formateo de las respuestas recibidas. |


## 💻 Código Fuente Principal

El núcleo de la conexión se basa en la construcción dinámica de la cadena de conexión:
### 1. Codigo GeminiService.cs
<img width="656" height="765" alt="Captura de pantalla 2026-03-25 120110" src="https://github.com/user-attachments/assets/ccffa5fb-5a1d-478e-bf39-c48957e00d83" />

### 2. Cdigo Form1.cs
<img width="471" height="818" alt="Captura de pantalla 2026-03-25 120017" src="https://github.com/user-attachments/assets/edca1d52-7062-4bcd-9c59-0dad4f890777" />

---
**Desarrollado por:** Hector David Salcedo Magaña   
**Institución:** Centro Universitario De Ciencias Exactas e Ingenierías
