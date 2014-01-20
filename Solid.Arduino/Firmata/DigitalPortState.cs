﻿using System;
using System.Runtime.CompilerServices;

namespace Solid.Arduino.Firmata
{
    /// <summary>
    /// Represents the pin states of a digital port.
    /// </summary>
    public struct DigitalPortState
    {
        /// <summary>
        /// Gets the digital port number.
        /// </summary>
        public int Port { get; internal set; }

        /// <summary>
        /// Gets the bit-pattern value of the digital port.
        /// </summary>
        public int Pins { get; internal set; }

        /// <summary>
        /// Gets a value indicating if the given pin is 1 (high).
        /// </summary>
        /// <param name="pin">The 0-based pin number</param>
        /// <returns><c>true</c> when the pin has a binary 1 value, otherwise <c>false</c></returns>
        public bool IsHigh(int pin)
        {
            if (pin < 0 || pin > 7)
                throw new ArgumentOutOfRangeException("pin", Messages.ArgumentEx_PinRange0_7);

            return (Pins & 1 << pin) > 0;
        }
    }
}
