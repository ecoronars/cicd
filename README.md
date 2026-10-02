# Demo CI/CD con GitHub Actions (C#)

![CI/CD](https://github.com/ecoronars/cicd/actions/workflows/ci-cd.yml/badge.svg)

Proyecto mínimo en .NET 10 para mostrar cómo funciona un pipeline de CI/CD con GitHub Actions.

## Estructura

```
src/Calculadora/            Librería con operaciones básicas
src/CalculadoraApp/         App de consola que usa la librería
tests/Calculadora.Tests/    Tests unitarios con xUnit
.github/workflows/ci-cd.yml Pipeline de GitHub Actions
```

## El pipeline

| Job | Cuándo corre | Qué hace |
|-----|--------------|----------|
| **build-and-test** (CI) | En cada push y pull request a `main` | Restaura, compila y ejecuta los tests |
| **publish** (CD) | Solo en push a `main`, y solo si CI pasó | Publica la app, la ejecuta y la sube como artefacto descargable |

## Ejecutar localmente

```bash
dotnet build
dotnet test
dotnet run --project src/CalculadoraApp
```

## Guion para la demo

1. **Pipeline verde:** haz push a `main` y abre la pestaña **Actions**. Verás los dos jobs y, al final, el artefacto `calculadora-app` para descargar.
2. **Romper un test:** crea una rama, cambia `Sumar` en [Calculadora.cs](src/Calculadora/Calculadora.cs) para que regrese `a - b` y abre un pull request. El job de CI falla, el PR lo marca en rojo y el job de publicación no se ejecuta.
3. **Arreglarlo:** revierte el cambio, haz push a la rama y el PR vuelve a verde.
