# StockNova 📦

Sistema de gestión de inventario y control de stock desarrollado en C# .NET Windows Forms con arquitectura en capas y persistencia en SQL Server.

## 🚀 Características
- **Control de Inventarios:** Registro y consulta de productos con estado de stock.
- **Gestión de Usuarios:** Módulo de autenticación y control de accesos.
- **Arquitectura Limpia:** Separación por capas de presentación, lógica de negocio, acceso a datos y entidades.
- **Persistencia:** Integración con SQL Server mediante scripts directos.

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C# (.NET)
- **Interfaz:** Windows Forms
- **Base de Datos:** SQL Server
- **Arquitectura:** N-Capas (`StockNova.UI`, `StockNova.BLL`, `StockNova.DAL`, `StockNova.Entities`)

## 🗄️ Base de Datos
El script para la creación de tablas, relaciones e inserciones de datos iniciales se encuentra en la raíz del repositorio (`StockNova.sql`).