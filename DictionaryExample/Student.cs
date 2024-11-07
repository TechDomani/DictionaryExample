using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
	internal class Student
	{
		// Fields
		private string _firstName;
		private string _surname;
		private List<string> _subjects = [];

		// Properties
		public string FullName
		{
			get
			{
				return $"{_firstName} {_surname}";
			}
		}
		public DateOnly DateOfBirth { get; private set; }

		//Constructor
		public Student(string firstName, string surname, DateOnly dateOfBirth)
		{
			_firstName = firstName;
			_surname = surname;
			DateOfBirth = dateOfBirth;
		}

		// Methods
		public void AddSubject(string subject)
		{
			if (!_subjects.Contains(subject))
			{
				_subjects.Add(subject);
			}
		}

		public string GetSubjects()
		{
			return string.Join("\n", _subjects);
		}

	}
}
