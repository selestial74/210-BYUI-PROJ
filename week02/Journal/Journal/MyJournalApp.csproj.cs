import json
from datetime import datetime
import random

# Entry Class
class Entry:
    def __init__(self, date, prompt, text):
        self.date = date
        self.prompt = prompt
        self.text = text

    def to_dict(self):
        return {"date": self.date, "prompt": self.prompt, "text": self.text}

    @staticmethod
    def from_dict(data):
        return Entry(data["date"], data["prompt"], data["text"])

# Journal Class
class Journal:
    def __init__(self):
        self.entries = []
        self.prompts = [
            "What made you smile today?",
            "Describe a challenge you overcame this week.",
            "What are you grateful for right now?",
            "Write about a recent memory you cherish.",
            "What are your goals for the coming week?"
        ]

    def add_entry(self, prompt, text):
        date = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
        entry = Entry(date, prompt, text)
        self.entries.append(entry)

    def display_entries(self):
        if not self.entries:
            print("No entries found.")
            return
        for entry in self.entries:
            print(f"Date: {entry.date}\nPrompt: {entry.prompt}\nEntry: {entry.text}\n")

    def save_to_file(self, filename):
        with open(filename, "w") as file:
            json.dump([entry.to_dict() for entry in self.entries], file, indent=4)
        print(f"Journal saved to {filename}.")

    def load_from_file(self, filename):
        try:
            with open(filename, "r") as file:
                data = json.load(file)
                self.entries = [Entry.from_dict(item) for item in data]
            print(f"Journal loaded from {filename}.")
        except FileNotFoundError:
            print(f"File {filename} not found.")

    def generate_prompt(self):
        return random.choice(self.prompts)

# Main Program
def main():
    journal = Journal()
    while True:
        print("\nJournal Manager")
        print("1. Write a new entry")
        print("2. Display all entries")
        print("3. Save journal to file")
        print("4. Load journal from file")
        print("5. Exit")

        choice = input("Choose an option: ")

        if choice == "1":
            prompt = journal.generate_prompt()
            print(f"Prompt: {prompt}")
            text = input("Your response: ")
            journal.add_entry(prompt, text)
        elif choice == "2":
            journal.display_entries()
        elif choice == "3":
            filename = input("Enter filename to save: ")
            journal.save_to_file(filename)
        elif choice == "4":
            filename = input("Enter filename to load: ")
            journal.load_from_file(filename)
        elif choice == "5":
            print("Farewell!")
            break
        else:
            print("Invalid choice. Please try again.")

if __name__ == "__main__":
    main()
