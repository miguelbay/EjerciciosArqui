async function buscarCliente() {
    const cedula = document.getElementById('cedulaInput').value.trim();
    const resultado = document.getElementById('resultado');
    resultado.innerHTML = "<p class='loading'>Buscando...</p>";
  
    try {
      const res = await fetch(`http://localhost:5198/api/cliente/${cedula}`);
      if (!res.ok) {
        resultado.innerHTML = "<p class='error'>Cliente no encontrado.</p>";
        return;
      }
  
      const data = await res.json();
  
      resultado.innerHTML = `
        <div class="card">
          <h2>${data.nombre}</h2>
          <p><strong>Cédula:</strong> ${data.cedula}</p>
          <p><strong>Dirección:</strong> ${data.direccion}</p>
          <p><strong>Teléfono:</strong> ${data.telefono}</p>
        </div>
      `;
    } catch (error) {
      resultado.innerHTML = "<p class='error'>Error al conectar con el servidor.</p>";
      console.error(error);
    }
  }
  