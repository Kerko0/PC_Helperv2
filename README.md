# PC Helper

PC Helper is a tool to help you figure out what PC parts you need for your next build.

## Prerequisites

- Docker Desktop

## Getting started

Download or clone the git repo to a folder of your choice on your computer.

```bash
git clone https://github.com/Kerko0/PC_Helperv2.git
```
Navigate to the folder you downloaded the repo and open it in either the command prompt or an IDE of your choice (i.e Visual Studio Code)
```bash
cd /PC_Helperv2
```

To start the application run docker-compose in the repo folder.

```bash
docker-compose up -d
```
After the container has launched navigate to the frontend page on port 4200.

## Usage

### Configuration
Before taking the quiz you must first configure the PC components. There are 4 different types of components each with different variables:
- CPU
  - `NAME:` Name of the processor 
  - `BRAND:` Processor brand (i.e Intel, AMD)
  - `PRICE:` Price of the processor
- GPU
  - `NAME:` Name of the graphics card
  - `BRAND:` Processor brand (i.e Nvidia, AMD)
  - `PRICE:` Price of the graphics card
- RAM
  - `CAPACITY:` RAM Capacity
  - `TYPE:` RAM Type (i.e DDR4, DDR5, only number is required)
  - `PRICE:` Price of the RAM
- Motherboard **(MAKE SURE THE MOTHERBOARD SOCKET AND CHIPSET MATCHES THE PROCESSOR AND SUPPORTS THE RAM TYPE)**
  - `NAME:` Name of the motherboard 
  - `PRICE:` Price of the motherboard

This is because the PC component market is ever-changing and the same components may not be available for everyone or have the same value.

The components are divided into different **Tiers** based on their performance. There are no set rules for what components should go into what tier however some general recommendation would be:

- **Tier 1:** 
  - `CPU:` Any top of the line CPU released after 2020. 
  - `GPU:` Any top of the line graphics card released after 2020. (RTX xx80 Ti/90-series card from Nvidia or x900 XT from AMD)
  - `RAM:` Up to 64 GB but recommended is 32 GB.
  - `Motherboard:` Any >$300-400 motherboard that matches the chipset and socket of the chosen processor.
- **Tier 2**
  - `CPU:` Any high mid-range CPU released after 2020 (i7/Ryzen 7)
  - `GPU:` Any high mid-range card released after 2020 (RTX xx70/70 Ti-series card from Nvidia or x800/800 XT from AMD)   
  - `RAM:` 32 GB
  - `Motherboard:` Any >$250-300 motherboard that matches the chipset and socket of the chosen processor.
- **Tier 3**
  - `CPU:` Any mid-range CPU released after 2019 (i5/Ryzen 5)
  - `GPU:` Any mid-range card released after 2020 (RTX xx60/60 Ti-series card from Nvidia or x700/700 XT from AMD)   
  - `RAM:` 16 GB
  - `Motherboard:` Any >$200-250 motherboard that matches the chipset and socket of the chosen processor.
- **Tier 4**
  - `CPU:` Any budget CPU released after 2019 (i3/Ryzen 3)
  - `GPU:` Any budget card released after 2018 (Avoid GT models from Nvidia like the GT 730 or 1030)
  - `RAM:` 16 GB
  - `Motherboard:` Any >$100-150 motherboard that matches the chipset and socket of the chosen processor.

You can also put a different component than recommended if it matches the same performance.
For example if you're fine with buying used cards a **RTX 2080 SUPER** performs almost the same as a **RTX 3060 Ti** at a potential better price if you're lucky. 

After you've configured all the components and all the fields are filled in you press the **SAVE** button to save your changes.

If you want to clear your saved data press the **RESET** button.

You can also export and import data using the respective buttons for sharing purposes. Exporting creates a `.json` file with the PC compoent data and saves it to your computer. To import you simply press the **Import** button and select the file you want to import.

**Make sure to save after importing!**

### The Quiz
If **ALL** PC components have been properly added to each Tier you can do the quiz.

Select the option that matches your answer to the question best for each question and once done press **Submit**. 

This will display your results at the bottom. 

To re-do the test just refresh the page.

## Application Overview

### Development tools

This application was developed using the following frameworks and tools:
- ASP.NET CORE
- Blazor WebAssembly
- Entity Framework
- PostgreSQL
- Docker

### Architecture

The project consists of:
- **Frontend Blazor WebAssembly App:** User interface.
- **Backend ASP.NET Core Hosted Web App:** The API handling requests between the frontend app and database.
- **PostgreSQL Database:** SQL Database with good Docker integration to host the application's data.

## Cloud Infrastructure

The cloud infrastructure of this application consists of the following Azure resources:
- Resource Group
- App Service (S1)
- 2 Web Apps for Frontend and Backend respectively
- Azure PostgreSQL Database

### Availability and Scaling

To make sure the application runs as expected I have implemented auto-scaling features for the App Service to make sure it can handle heavier loads. 

#### Autoscale Rules:
- `Scale out if the CPU percentage is over 80 percent, up to 5 instances`
- `Scale in if the CPU percentage decreases`

Because this app is not only lightweight but also probably wont have high demand and generate any money, the availability is not very important. It is also further strengthened by the fact that this app can very easily be run locally if the cloud hosted app isn't working as expected. 


