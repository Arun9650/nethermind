// SPDX-FileCopyrightText: 2022 Demerzel Solutions Limited
// SPDX-License-Identifier: LGPL-3.0-only

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nethermind.State.Snap
{
    public class AccountsAndProofs
    {
        public PathWithAccount[] PathAndAccounts { get; set; }
        public byte[][] Proofs { get; set; }
    }
}
