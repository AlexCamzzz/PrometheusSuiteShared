namespace PrometheusSuite.Shared.Enums;

public enum LoginStatus
{
    Success,              // Todo OK, acceso total.
    InvalidCredentials,   // Email/Pass incorrectos o no existe.
    HardwareMismatch,     // Licencia válida, pero PC incorrecta (Security violation).
    SubscriptionExpired,  // Licencia vencida (Soft Lock / Read Only).
    SubscriptionInactive, // Suspendida manualmente o pago fallido (Hard Lock).
    ServerMaintenance     // (Opcional) Por si necesitas bajar el switch globalmente.
}