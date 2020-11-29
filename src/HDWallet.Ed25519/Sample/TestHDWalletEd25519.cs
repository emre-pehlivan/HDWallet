using HDWallet.Core;

namespace HDWallet.Ed25519.Sample
{
    public class TestHDWalletEd25519 : HdWalletEd25519<CardanoSampleWallet>
    {
        public TestHDWalletEd25519(string seed) : base(seed) {}
        public TestHDWalletEd25519(string words, string seedPassword, string path) : base(words, seedPassword, path) {}
    }
}