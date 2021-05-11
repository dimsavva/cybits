using System;
using System.Collections.Generic;
using Blockcore.Consensus.Checkpoints;
using CyBits.Networks;
using CyBits.Networks.Setup;
using NBitcoin;

namespace CyBits
{
   internal class CyBitsSetup
   {
      internal static CyBitsSetup Instance = new CyBitsSetup();

      internal CoinSetup Setup = new CoinSetup
      {
         FileNamePrefix = "cybits",
         ConfigFileName = "cybits.conf",
         Magic = "01-4D-59-43",
         CoinType = 3601, // SLIP-0044: https://github.com/satoshilabs/slips/blob/master/slip-0044.md,
         PremineReward = 10000000,
         PoWBlockReward = 30,
         PoSBlockReward = 30,
         LastPowBlock = 100,
         GenesisText = "Cybits Blockchain", // The New York Times, 2020-04-16
         TargetSpacing = TimeSpan.FromSeconds(48),
         ProofOfStakeTimestampMask = 0x0000000F, // 0x0000003F // 45 sec
         PoSVersion = 4
      };

      internal NetworkSetup Main = new NetworkSetup
      {
         Name = "CyBitsMain",
         RootFolderName = "cybits",
         CoinTicker = "CY",
         DefaultPort = 15001,
         DefaultRPCPort = 15002,
         DefaultAPIPort = 15003,
         PubKeyAddress = 28, // B https://en.bitcoin.it/wiki/List_of_address_prefixes
         ScriptAddress = 87, // b
         SecretAddress = 160,
         GenesisTime = 1619785535,
         GenesisNonce = 1378520,
         GenesisBits = 0x1E0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00000ad5fd7641b4fe175234a90a453f987ff4b160e4e3d48b6fcd1fd9799f8c",
         HashMerkleRoot = "3c8573178b1637d5e9d7746daee99bf52db4ccc01b4bda2c216571b6c2bc3b7b",
         DNS = new[] { "seed1.cybits.org", "seed2.cybits.org" },
         Nodes = new[] { "144.91.123.46", "161.97.135.78" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup RegTest = new NetworkSetup
      {
         Name = "CyBitsRegTest",
         RootFolderName = "cybitsregtest",
         CoinTicker = "TCY",
         DefaultPort = 25001,
         DefaultRPCPort = 25002,
         DefaultAPIPort = 25003,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1619785668,
         GenesisNonce = 22647,
         GenesisBits = 0x1F00FFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00007e7f4c2a734695b076d3927c4a627af7f946cbb4f3fdc66c700706d4148a",
         HashMerkleRoot = "067e5bd89bfe3f94e088bbd4f775aba4ca9cbcd3b75c91bcb948c3ccd0ab69d9",
         DNS = new[] { "seed1.cybits.org", "seed2.cybits.org" },
         Nodes = new[] { "144.91.123.46", "161.97.135.78" },
          Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup Test = new NetworkSetup
      {
         Name = "CyBitsTest",
         RootFolderName = "cybitstest",
         CoinTicker = "TCY",
         DefaultPort = 35001,
         DefaultRPCPort = 35002,
         DefaultAPIPort = 35003,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1619785671,
         GenesisNonce = 16346,
         GenesisBits = 0x1F0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "0004503eeed5d597a48caadfe87799d6dc340bcc105d50f959556f50aece4594",
         HashMerkleRoot = "f66e1dc80782df2046a24eb862928d66c884734cfbd6adabc2dd78de87b3b9fc",
         DNS = new[] { "seed1.cybits.org", "seed2.cybits.org" },
         Nodes = new[] { "144.91.123.46", "161.97.135.78" },
          Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      public bool IsPoSv3()
      {
         return Setup.PoSVersion == 3;
      }

      public bool IsPoSv4()
      {
         return Setup.PoSVersion == 4;
      }
   }
}
