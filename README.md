# HimuOJ Contracts

`himuoj-contracts` 是 HimuOJ 系统跨仓库通信契约的单一事实源（Single Source of Truth）。

## Scope

本仓库只包含契约定义，不包含业务逻辑。

- `openapi/`：SPA -> BFF 与 BFF -> Downstream 的 HTTP API OpenAPI 规范。
- `grpc/`：Orchestrator 与 Worker 间 UDS/gRPC 的 `.proto` 契约。
- `events/`：RabbitMQ/CAP 事件模型（JSON Schema + C# DTO）。
- `csharp-refit/`：.NET 侧可直接引用的 Refit 强类型接口（零实现）。

## Minimal MVP (HelloWorld)

当前仓库提供一套最小可验证契约：

- HTTP: `GET /api/v1/hello`
- gRPC: `JudgePingService.Ping`
- Event: `SubmissionCreatedEvent`（v1）
- Refit: `IHelloApi`

## Structure

```text
himuoj-contracts/
├── openapi/
├── grpc/
├── events/
│   ├── schemas/
│   └── csharp/
└── csharp-refit/
```

## Versioning

遵循 SemVer：

- Breaking Change -> Major
- Additive Change -> Minor
- Internal docs/chore -> Patch

建议所有消费者仓库通过 Git Submodule + Git Tag 绑定版本。
