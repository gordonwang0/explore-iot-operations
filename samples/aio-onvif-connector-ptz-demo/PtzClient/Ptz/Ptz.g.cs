/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace PtzClient.Ptz
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Azure.Iot.Operations.Protocol.Models;
    using Azure.Iot.Operations.Protocol;
    using Azure.Iot.Operations.Protocol.RPC;
    using Azure.Iot.Operations.Protocol.Telemetry;
    using PtzClient;

    [CommandTopic("{ex:namespace}/mrpc/{ex:asset}/{commandName}")]
    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public static partial class Ptz
    {
        public abstract partial class Client : IAsyncDisposable
        {
            private ApplicationContext applicationContext;
            private IMqttPubSubClient mqttClient;
            private readonly GetNodesCommandInvoker getNodesCommandInvoker;
            private readonly GetNodeCommandInvoker getNodeCommandInvoker;
            private readonly AbsoluteMoveCommandInvoker absoluteMoveCommandInvoker;
            private readonly RelativeMoveCommandInvoker relativeMoveCommandInvoker;
            private readonly ContinuousMoveCommandInvoker continuousMoveCommandInvoker;
            private readonly StopCommandInvoker stopCommandInvoker;
            private readonly GetConfigurationsCommandInvoker getConfigurationsCommandInvoker;
            private readonly GetConfigurationCommandInvoker getConfigurationCommandInvoker;
            private readonly GetConfigurationOptionsCommandInvoker getConfigurationOptionsCommandInvoker;
            private readonly SetConfigurationCommandInvoker setConfigurationCommandInvoker;
            private readonly GetStatusCommandInvoker getStatusCommandInvoker;
            private readonly GetPresetsCommandInvoker getPresetsCommandInvoker;
            private readonly SetPresetCommandInvoker setPresetCommandInvoker;
            private readonly RemovePresetCommandInvoker removePresetCommandInvoker;
            private readonly GotoPresetCommandInvoker gotoPresetCommandInvoker;
            private readonly GotoHomePositionCommandInvoker gotoHomePositionCommandInvoker;
            private readonly SetHomePositionCommandInvoker setHomePositionCommandInvoker;
            private readonly SendAuxiliaryCommandCommandInvoker sendAuxiliaryCommandCommandInvoker;

            public Client(ApplicationContext applicationContext, IMqttPubSubClient mqttClient)
            {
                this.applicationContext = applicationContext;
                this.mqttClient = mqttClient;
                this.CustomTopicTokenMap = new();

                this.getNodesCommandInvoker = new GetNodesCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.getNodeCommandInvoker = new GetNodeCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.absoluteMoveCommandInvoker = new AbsoluteMoveCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.relativeMoveCommandInvoker = new RelativeMoveCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.continuousMoveCommandInvoker = new ContinuousMoveCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.stopCommandInvoker = new StopCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.getConfigurationsCommandInvoker = new GetConfigurationsCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.getConfigurationCommandInvoker = new GetConfigurationCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.getConfigurationOptionsCommandInvoker = new GetConfigurationOptionsCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.setConfigurationCommandInvoker = new SetConfigurationCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.getStatusCommandInvoker = new GetStatusCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.getPresetsCommandInvoker = new GetPresetsCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.setPresetCommandInvoker = new SetPresetCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.removePresetCommandInvoker = new RemovePresetCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.gotoPresetCommandInvoker = new GotoPresetCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.gotoHomePositionCommandInvoker = new GotoHomePositionCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.setHomePositionCommandInvoker = new SetHomePositionCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
                this.sendAuxiliaryCommandCommandInvoker = new SendAuxiliaryCommandCommandInvoker(applicationContext, mqttClient) { CustomTopicTokenMap = this.CustomTopicTokenMap };
            }

            public GetNodesCommandInvoker GetNodesCommandInvoker { get => this.getNodesCommandInvoker; }
            public GetNodeCommandInvoker GetNodeCommandInvoker { get => this.getNodeCommandInvoker; }
            public AbsoluteMoveCommandInvoker AbsoluteMoveCommandInvoker { get => this.absoluteMoveCommandInvoker; }
            public RelativeMoveCommandInvoker RelativeMoveCommandInvoker { get => this.relativeMoveCommandInvoker; }
            public ContinuousMoveCommandInvoker ContinuousMoveCommandInvoker { get => this.continuousMoveCommandInvoker; }
            public StopCommandInvoker StopCommandInvoker { get => this.stopCommandInvoker; }
            public GetConfigurationsCommandInvoker GetConfigurationsCommandInvoker { get => this.getConfigurationsCommandInvoker; }
            public GetConfigurationCommandInvoker GetConfigurationCommandInvoker { get => this.getConfigurationCommandInvoker; }
            public GetConfigurationOptionsCommandInvoker GetConfigurationOptionsCommandInvoker { get => this.getConfigurationOptionsCommandInvoker; }
            public SetConfigurationCommandInvoker SetConfigurationCommandInvoker { get => this.setConfigurationCommandInvoker; }
            public GetStatusCommandInvoker GetStatusCommandInvoker { get => this.getStatusCommandInvoker; }
            public GetPresetsCommandInvoker GetPresetsCommandInvoker { get => this.getPresetsCommandInvoker; }
            public SetPresetCommandInvoker SetPresetCommandInvoker { get => this.setPresetCommandInvoker; }
            public RemovePresetCommandInvoker RemovePresetCommandInvoker { get => this.removePresetCommandInvoker; }
            public GotoPresetCommandInvoker GotoPresetCommandInvoker { get => this.gotoPresetCommandInvoker; }
            public GotoHomePositionCommandInvoker GotoHomePositionCommandInvoker { get => this.gotoHomePositionCommandInvoker; }
            public SetHomePositionCommandInvoker SetHomePositionCommandInvoker { get => this.setHomePositionCommandInvoker; }
            public SendAuxiliaryCommandCommandInvoker SendAuxiliaryCommandCommandInvoker { get => this.sendAuxiliaryCommandCommandInvoker; }

            public Dictionary<string, string> CustomTopicTokenMap { get; private init; }

            public RpcCallAsync<GetNodesResponsePayload> GetNodesAsync(CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<GetNodesResponsePayload>(this.getNodesCommandInvoker.InvokeCommandAsync(new EmptyJson(), metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<GetNodeResponsePayload> GetNodeAsync(GetNodeRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<GetNodeResponsePayload>(this.getNodeCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> AbsoluteMoveAsync(AbsoluteMoveRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<EmptyJson>(this.absoluteMoveCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> RelativeMoveAsync(RelativeMoveRequestPayload request, Dictionary<string, string> customTopicTokens, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                customTopicTokens["invokerClientId"] = clientId;

                return new RpcCallAsync<EmptyJson>(this.relativeMoveCommandInvoker.InvokeCommandAsync(request, metadata, customTopicTokens, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> ContinuousMoveAsync(ContinuousMoveRequestPayload request, Dictionary<string, string> customTopicTokens, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                customTopicTokens["invokerClientId"] = clientId;

                return new RpcCallAsync<EmptyJson>(this.continuousMoveCommandInvoker.InvokeCommandAsync(request, metadata, customTopicTokens, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> StopAsync(StopRequestPayload request, Dictionary<string, string> customTopicTokens, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                customTopicTokens["invokerClientId"] = clientId;

                return new RpcCallAsync<EmptyJson>(this.stopCommandInvoker.InvokeCommandAsync(request, metadata, customTopicTokens, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<GetConfigurationsResponsePayload> GetConfigurationsAsync(CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<GetConfigurationsResponsePayload>(this.getConfigurationsCommandInvoker.InvokeCommandAsync(new EmptyJson(), metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<GetConfigurationResponsePayload> GetConfigurationAsync(GetConfigurationRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<GetConfigurationResponsePayload>(this.getConfigurationCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<GetConfigurationOptionsResponsePayload> GetConfigurationOptionsAsync(GetConfigurationOptionsRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<GetConfigurationOptionsResponsePayload>(this.getConfigurationOptionsCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> SetConfigurationAsync(SetConfigurationRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<EmptyJson>(this.setConfigurationCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<GetStatusResponsePayload> GetStatusAsync(GetStatusRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<GetStatusResponsePayload>(this.getStatusCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<GetPresetsResponsePayload> GetPresetsAsync(GetPresetsRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<GetPresetsResponsePayload>(this.getPresetsCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<SetPresetResponsePayload> SetPresetAsync(SetPresetRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<SetPresetResponsePayload>(this.setPresetCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> RemovePresetAsync(RemovePresetRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<EmptyJson>(this.removePresetCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> GotoPresetAsync(GotoPresetRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<EmptyJson>(this.gotoPresetCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> GotoHomePositionAsync(GotoHomePositionRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<EmptyJson>(this.gotoHomePositionCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<EmptyJson> SetHomePositionAsync(SetHomePositionRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<EmptyJson>(this.setHomePositionCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public RpcCallAsync<SendAuxiliaryCommandResponsePayload> SendAuxiliaryCommandAsync(SendAuxiliaryCommandRequestPayload request, CommandRequestMetadata? requestMetadata = null, TimeSpan? commandTimeout = default, CancellationToken cancellationToken = default)
            {
                string? clientId = this.mqttClient.ClientId;
                if (string.IsNullOrEmpty(clientId))
                {
                    throw new InvalidOperationException("No MQTT client Id configured. Must connect to MQTT broker before invoking command.");
                }

                CommandRequestMetadata metadata = requestMetadata ?? new CommandRequestMetadata();
                Dictionary<string, string>? transientTopicTokenMap = new()
                {
                    { "invokerClientId", clientId },
                };

                return new RpcCallAsync<SendAuxiliaryCommandResponsePayload>(this.sendAuxiliaryCommandCommandInvoker.InvokeCommandAsync(request, metadata, transientTopicTokenMap, commandTimeout, cancellationToken), metadata.CorrelationId);
            }

            public async ValueTask DisposeAsync()
            {
                await this.getNodesCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.getNodeCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.absoluteMoveCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.relativeMoveCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.continuousMoveCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.stopCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.getConfigurationsCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.getConfigurationCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.getConfigurationOptionsCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.setConfigurationCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.getStatusCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.getPresetsCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.setPresetCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.removePresetCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.gotoPresetCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.gotoHomePositionCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.setHomePositionCommandInvoker.DisposeAsync().ConfigureAwait(false);
                await this.sendAuxiliaryCommandCommandInvoker.DisposeAsync().ConfigureAwait(false);
            }

            public async ValueTask DisposeAsync(bool disposing)
            {
                await this.getNodesCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.getNodeCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.absoluteMoveCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.relativeMoveCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.continuousMoveCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.stopCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.getConfigurationsCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.getConfigurationCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.getConfigurationOptionsCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.setConfigurationCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.getStatusCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.getPresetsCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.setPresetCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.removePresetCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.gotoPresetCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.gotoHomePositionCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.setHomePositionCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
                await this.sendAuxiliaryCommandCommandInvoker.DisposeAsync(disposing).ConfigureAwait(false);
            }
        }
    }
}
