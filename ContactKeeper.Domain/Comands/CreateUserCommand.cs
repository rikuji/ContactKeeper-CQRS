using ContactKeeper.Domain.Comands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace ContactKeeper.Domain.Comands
{
    public class CreateUserCommand : Notifiable, ICommand
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsEmail(Email, "Email", "Usuário inválido")
                .AreEquals(Password, ConfirmPassword, "Password", "As senhas não conferem")
            );
        }
    }
}
