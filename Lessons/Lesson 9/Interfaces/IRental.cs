//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>31-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

namespace Lesson_9.Interfaces;

/// <summary>
/// Interface Rental
/// </summary>
public interface IRental
{
    void CalculateRentalCost();
    void PrintRentalSummary();
}