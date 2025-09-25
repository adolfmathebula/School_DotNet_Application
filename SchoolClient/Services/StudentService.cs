using System.Net.Http.Json;
using SchoolClient.Models;


namespace SchoolClient.Services
    {
        
    public class StudentService
    {
        private readonly HttpClient _http;
        public StudentService(HttpClient http) => _http = http;

        public async Task<List<Student>> GetStudents() =>
            await _http.GetFromJsonAsync<List<Student>>("api/students");

        public async Task<Student?> GetStudent(int id) =>
            await _http.GetFromJsonAsync<Student?>($"api/students/{id}");

        public async Task AddStudent(Student student) =>
            await _http.PostAsJsonAsync("api/students", student);

        public async Task UpdateStudent(Student student) =>
            await _http.PutAsJsonAsync($"api/students/{student.Id}", student);

        public async Task DeleteStudent(int id) =>
            await _http.DeleteAsync($"api/students/{id}");
    }
}