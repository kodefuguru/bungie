namespace BaseJump.Core.Conventions
{
    internal partial interface IConvention<TEvidence, TResult>
    {
        TResult From(TEvidence evidence);
    }
}
