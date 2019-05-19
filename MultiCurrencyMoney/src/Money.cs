﻿// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;

namespace MultiCurrencyMoney
{
    public class Money
    {
        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public string Currency()
        {
            return currency;
        }

        public override bool Equals(Object o)
        {
            Money money = (Money)o;
            return amount == money.amount && currency.Equals(money.currency);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return amount + " " + currency;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}
