import './App.css'
import Carousel from './components/Carousel'

function App() {
  return (
    <>
      <div>
        <Carousel api="https://api.jikan.moe/v4/seasons/now" />
      </div>
    </>
  )
}

export default App
