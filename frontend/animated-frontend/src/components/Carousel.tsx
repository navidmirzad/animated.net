import "../App.css";
import { useState, useEffect } from "react";
import type AnimeType from "../types/AnimeType";

const Carousel = ({ api }: { api: string }) => {
  const [animeList, setAnimeList] = useState<AnimeType[]>([]);
  const [index, setIndex] = useState(0);

  const animesPerView = 4;

  useEffect(() => {
    const fetchAnimeList = async () => {
      const response = await fetch(api);
      const data = await response.json();
      setAnimeList(data.data);
    };

    fetchAnimeList();
  }, [api]);

  const handleNext = () => {
    if (animeList.length === 0) return;
    if (index + animesPerView >= animeList.length) {
      setIndex(0);
    } else {
      setIndex(index + animesPerView);
    }
  };

  const handlePrev = () => {
    if (animeList.length === 0) return;
    const lastStart = Math.max(0, (Math.ceil(animeList.length / animesPerView) - 1) * animesPerView);
    if (index === 0) {
      setIndex(lastStart);
    } else {
      setIndex(Math.max(0, index - animesPerView));
    }
  };

  return (
    <div className="w-full flex flex-col items-center">
      <div className="relative w-200 overflow-hidden group">
        <button
          type="button"
          onClick={handlePrev}
          aria-label="Previous anime"
          className="btn-widget-slide-side left absolute top-1/2 z-10 -left-10 h-20 w-20 -translate-y-1/2 rounded-full border border-white/20 bg-black/60 opacity-0 transition-all duration-300 group-hover:opacity-100"
        >
          <span className="btn-inner block h-4 w-4 rotate-45 border-l-2 border-b-2 border-white" />
        </button>

        <ul
          className="flex transition-transform duration-500 ease-in-out"
          style={{
            transform: `translateX(-${index * (100 / animesPerView)}%)`,
          }}
        >
          {animeList.map((anime) => (
            <li key={anime.mal_id} className="w-1/4 shrink-0 px-2">
              <img
                className="w-full object-cover transition-transform duration-300 hover:scale-110"
                src={anime.images.jpg.image_url}
                alt={anime.title}
              />
            </li>
          ))}
        </ul>

        <button
          type="button"
          onClick={handleNext}
          aria-label="Next anime"
          className="btn-widget-slide-side right absolute top-1/2 z-10 -right-10 h-20 w-20 -translate-y-1/2 rounded-full border border-white/20 bg-black/60 opacity-0 transition-all duration-300 group-hover:opacity-100"
        >
          <span className="btn-inner block h-4 w-4 rotate-225 border-l-2 border-b-2 border-white" />
        </button>
      </div>
    </div>
  );
};

export default Carousel;
